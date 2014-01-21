using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace MyFileBrowser
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// 系统初始化
        /// </summary>
        private void Init()
        {
            //添加所有驱动器节点
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drv in drives)
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = drv.Name;
                item.Tag = drv; //保存drv对象
                (tvwFolder.Items[0] as TreeViewItem).Items.Add(item);
            }
        }

        private void tvwFolder_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem item = e.NewValue as TreeViewItem;
            //根节点不用提取文件 
            if((item!=null) &&( item.Tag!=null))
            {

                DriveInfo drv = item.Tag as DriveInfo;
                DirectoryInfo dir = item.Tag as DirectoryInfo;
                string FolderName="";
                if (drv != null)
                    FolderName = drv.Name;
                if (dir != null)
                    FolderName = dir.FullName;

                //显示当前文件夹下的所有文件
                List<FileInfo> files = FileBrowserHelper.GetAllFilesInFolder(FolderName);
                lstFiles.ItemsSource = files;
              
                //如果此节点下已有子文件夹,则不再重新添加子节点
                //这是为了简化代码而采取的方法,但可能得不到最新的数据
                //因为很有可能正在运行此程序时,文件系统发生了改变
                //作为教学实例,就不处理这些情况了
                if (item.HasItems == true)
                    return;

                //添加子文件夹
                List<DirectoryInfo> dirs = FileBrowserHelper.GetAllSubDirectories(FolderName);
                if (dirs != null)
                {
                    foreach (DirectoryInfo obj in dirs)
                    {
                        TreeViewItem dirItem = new TreeViewItem();
                        dirItem.Header = obj.Name;
                        dirItem.Tag = obj;
                        item.Items.Add(dirItem);
                    }
                    item.IsExpanded = true; //自动展开子树
                }

            }
        }
    }
}
