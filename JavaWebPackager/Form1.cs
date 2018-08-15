using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JavaWebPackager
{
    public partial class MainForm : Form
    {

        Point mouseOff;
        bool leftFlag;

        public MainForm()
        {
            InitializeComponent();

            TargetText.Text= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+@"\Yips_Version\";
        }

        private string GetFileMD5(string filePath)
        {
            string ret;

            try
            {
                FileStream file = new FileStream(filePath, FileMode.Open);
                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }

                ret = sb.ToString();
            }
            catch (Exception e)
            {
                ret = "";
            }

            return ret;
        }
        private void ShowTotal(int folder, int folderCount, int file, int fileCount)
        {
            totalLabel.Text = String.Format("共 {0}/ {1} 文件夹，{2} / {3} 文件", folder, folderCount, file, fileCount);
        }
        private void ShowRsult(string result)
        {
            ResultListbox.Items.Add(result);
            this.ResultListbox.TopIndex = this.ResultListbox.Items.Count - (int)(this.ResultListbox.Height / this.ResultListbox.ItemHeight);
        }


        private void Package(string sourcePath,string basePath,string targetPath)
        {

            if (sourcePath[sourcePath.Length - 1] != '\\')
            {
                sourcePath += '\\';
            }

            if (basePath[basePath.Length - 1] != '\\')
            {
                basePath += '\\';
            }

            if (targetPath[targetPath.Length - 1] != '\\')
            {
                targetPath += '\\';
            }

            string FullPath = targetPath + @"Full\";

            string AdditionalPath = targetPath + @"Addtional\";

            IList<string> fileList = new List<string>();

            int fileLength = 0;
            int fileTotalLength = 0;

            string filePath;

            string[] filenames = Directory.GetFileSystemEntries(sourcePath);


            fileTotalLength += filenames.Length;

            foreach (string file in filenames)
            {
                fileList.Add(file);
            }
            ShowTotal(filenames.Length, fileList.Count, fileLength, fileTotalLength);


            for (int i = 0; i < fileList.Count; i++)
            {
                filePath = fileList[i];

                if (Directory.Exists(filePath))// 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                {
                    filenames = Directory.GetFileSystemEntries(filePath);

                    fileTotalLength += filenames.Length;

                    foreach (string file in filenames)
                    {
                        fileList.Add(file);
                    }
                    ShowTotal(i, fileList.Count, fileLength, fileTotalLength);
                    ShowRsult("复制文件夹："+ filePath.Replace(sourcePath,""));
                }
                else // 否则直接copy文件
                {

                    fileLength += 1;

                    int startIndex = filePath.LastIndexOf(@"\");
                    string name = filePath.Substring(startIndex + 1);

                    if(name.Equals("") || name==null || name[0] == '.')
                    {
                        //do nothing
                    }
                    else
                    {
                      

                        //全量包
                        string fullFilePath = filePath.Replace(sourcePath, FullPath);
                        string targetFilePath = fullFilePath.Substring(0,fullFilePath.LastIndexOf(@"\"));
                        if (!Directory.Exists(targetFilePath))
                        {
                            Directory.CreateDirectory(targetFilePath);
                        }

                        File.Copy(filePath, fullFilePath, true);


                        //增量包
                        string baseFilePath = filePath.Replace(sourcePath, basePath);

                        string sourceFileMD5 = GetFileMD5(filePath);
                        string baseFileMD5 = GetFileMD5(baseFilePath);
                        if (!sourceFileMD5.Equals(baseFileMD5) && !sourceFileMD5.Equals("")) 
                        {
                            string AdditionalFilePath = filePath.Replace(sourcePath, AdditionalPath);

                            targetFilePath = AdditionalFilePath.Substring(0,AdditionalFilePath.LastIndexOf(@"\"));

                            if (!Directory.Exists(targetFilePath))
                            {
                                Directory.CreateDirectory(targetFilePath);
                            }

                            File.Copy(filePath, AdditionalFilePath, true);
                        }

                        ShowTotal(i, fileList.Count, fileLength, fileTotalLength);
                        ShowRsult("复制文件：" + filePath.Replace(sourcePath, ""));
                    }             
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pathBtn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            TextBox txt;


            switch (btn.Name)
            {
                case "SourceBtn":
                    txt = SourceText;
                    break;
                case "BaseBtn":
                    txt = BaseText;
                    break;
                case "TargetBtn":
                default:
                    txt = TargetText;
                    break;
            }

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = txt.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if(btn.Name== "SourceBtn")
                {
                    BaseText.Text = dialog.SelectedPath;
                }

                txt.Text = dialog.SelectedPath;
            }

        }

        private void PackageBtn_Click(object sender, EventArgs e)
        {
            ResultListbox.Items.Clear();

            if (!SourceText.Text.Equals("") && SourceText.Text != null &&
                !BaseText.Text.Equals("") && BaseText.Text != null &&
               !TargetText.Text.Equals("") && TargetText.Text != null)
            {
                string targetPath= TargetText.Text + @"\" + DateTime.Now.ToString("yyyyMMddHHmm");

                Package(SourceText.Text, BaseText.Text, targetPath);

                ShowRsult("打包比对完成，当前打包路径为："+ targetPath);
            }
            else
            {
                MessageBox.Show("路径有误！", "错误提示");
            }
        }

        //移动无框窗口
        private void Calc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }
        private void Calc_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                Location = mouseSet;
            }
        }
        private void Calc_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }
    }
}
