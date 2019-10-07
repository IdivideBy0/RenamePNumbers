using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RenamePNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFolderDialog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSelectedPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnScanAndRename_Click(object sender, EventArgs e)
        {
            //

            string sourceFile, targetFile;

            string[] files = Directory.GetFiles(txtSelectedPath.Text, "*.jpg");

            //File.Replace(sourceFile, targetFile, null);

            int count = 0;

            foreach(string filename in files)       
            {
                //++count;
                //txtDebug.Text = Convert.ToString(count);

                
                string[] file = filename.Split('\\');

                int len = file.Length;

                sourceFile= file[len -1];

                int n;

                if ((sourceFile.StartsWith("P") || sourceFile.StartsWith("p")) && int.TryParse(sourceFile.Substring(1, 1), out n))
                {
                   ++count;
                   lblCounter.Text = Convert.ToString(count);

                    // proposed renames

                    targetFile = sourceFile.Insert(1, "-");

                    //test if targetfile does not exist

                    if (!File.Exists(txtSelectedPath.Text + "\\" + targetFile))
                    {
                        File.Move(txtSelectedPath.Text + "\\" + sourceFile, txtSelectedPath.Text + "\\" + targetFile);
                    }
                    

                    txtDebug.Text += targetFile + Environment.NewLine;



                }
                
            }

        }
    }
}
