using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTextProcessingTool
{
    public partial class mainForm : Form
    {
        FileProcess fileProcess = new FileProcess();
        public mainForm()
        {
            InitializeComponent();
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            

            filePathTextbox.Text = fileProcess.GetFilePath();
            
            
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            var fileContent = fileProcess.GetFileContent();
            if (fileContent != null)
                foreach (var str in fileContent)
                {
                    resultRTextBox.Text +=  str + '\n';
                }
        }
    }
}
