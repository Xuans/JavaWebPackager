# 晴美 QinM  JavaWebPackager

> Java Web 打出全量包或增量包

> 需要注意的是，全量和增量包不提供达成 war 包或 tar 包的功能，近提供文件比对功能。


---


## Usage | 用法

  打开 `JavaWebPackager`
  
  ![](https://raw.githubusercontent.com/Xuans/JavaWebPackager/master/docs/1.jpg)
    
  1. 部署全量包
        
     选择 `Source Path` 一般问项目的 `WebContent` 地址，选择 `Target Path` ，一般为本地目录。
     
     打包完成后，结果中会显示打包好的目录，如果是全量打包，则会在该目录下有一个 `Full` 的文件夹，这个文件夹即为全量包。
     
     ![](https://raw.githubusercontent.com/Xuans/JavaWebPackager/master/docs/2.jpg)
  
  1. 增量部署
  
     增量包比全量包多的东西就是，选择一个基础的版本作为对比，选择 `Base Path ` 即可。
     
     增量打包完之后，会根据打包项目 `Source Path` 与基础项目 `Base Path ` 使用 MD5 对比，将不同的文件放在 `Target Path` 下的 `Additional` 下的文件夹。
     
     ![](https://raw.githubusercontent.com/Xuans/JavaWebPackager/master/docs/3.jpg)
     
     **需要注意：如果两个版本没有不同，将不会建立增量包 `Additional` 文件夹。**
     
  1. 增加部署回滚
  
     如果需要将增量部署的版本（版本B）部署到服务器后，需要将回滚到上一个版本（版本A），只要将需版本A作为 `Source Path`
，版本B作为 `Base Path` ，重新打包，增量包即为需要回滚的版本。

Written By C#

Author Kinsueng

Copyright Xuans Group

Under MIT License 
