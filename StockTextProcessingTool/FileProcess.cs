using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTextProcessingTool;
using System.IO;

namespace StockTextProcessingTool
{
    class FileProcess
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        string FilePath { get; set; }
        /// <summary>
        /// 文件名
        /// </summary>
        string FileName { get; set; }
        /// <summary>
        /// 文件内容
        /// </summary>
        List<string> FileContent { get; set; }
        //构造函数
        public FileProcess()
        {
            FileContent = new List<string>();
        }
        /// <summary>
        /// 获取文件路径
        /// </summary>
        /// <returns></returns>
       public string GetFilePath()
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件(*.txt;)|*.txt;|所有文件|*.*";
            openFileDialog.ValidateNames = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.CheckFileExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
            }

            return FilePath;
        }
        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <returns></returns>
        public List<string> GetFileContent()
        {

            StreamReader sr = new StreamReader(FilePath, Encoding.UTF8);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                if(line != null)
                {
                    if(line.ToString() != "")
                        FileContent.Add(line.ToString());
                }
                
            }

            return FileContent;
        }
    }
}
