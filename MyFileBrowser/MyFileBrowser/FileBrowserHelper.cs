using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MyFileBrowser
{
    class FileBrowserHelper
    {
        /// <summary>
        /// 获取指定文件夹下的所有文件(按大小升序排列)
        /// 有些文件夹要访问可能需要有特殊的权限,当不能拥有此权限时,简单地返回一个NULL指针
        /// </summary>
        /// <param name="FolderName"></param>
        /// <returns></returns>
        public static List<FileInfo> GetAllFilesInFolder(string FolderName)
        {
            try
            {
                List<FileInfo> files = null;
                if (Directory.Exists(FolderName))
                {
                    DirectoryInfo dir = new DirectoryInfo(FolderName);
                    files = dir.GetFiles().ToList<FileInfo>();
                    files.Sort(ComparisonFileInfo); //排序
                }
                return files;
            }
            catch
            {

                return null;
            }

        }
        /// <summary>
        /// 按大小比较文件
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int ComparisonFileInfo(FileInfo x, FileInfo y)
        {
            if (x.Length > y.Length)
                return 1;
            else
                if (x.Length < y.Length)
                    return -1;
                else
                    return 0;
        }

        /// <summary>
        /// 获取指定子文件夹下的所有子文件夹
        /// </summary>
        /// <param name="FolderName"></param>
        /// <returns></returns>
        public static List<DirectoryInfo> GetAllSubDirectories(string FolderName)
        {
            try
            {
   List<DirectoryInfo> dirs = null;
            if (Directory.Exists(FolderName))
            {
                DirectoryInfo dir = new DirectoryInfo(FolderName);
                dirs = dir.GetDirectories().ToList<DirectoryInfo>();

            }
            return dirs;
            }
            catch (Exception)
            {

                return null;
            }
         
        }
    }
}
