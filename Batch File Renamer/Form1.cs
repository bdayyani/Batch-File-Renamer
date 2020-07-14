using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MetroFramework;

namespace Batch_File_Renamer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public string Source_Folder = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            try
            {
                // Open all the thermal images
                listBox1.Items.Clear();
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Open the folder containing Thermal images";
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Source_Folder = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(Source_Folder);
                    foreach (string file in files)
                    {
                        try
                        {
                            string name = file.Replace((Source_Folder + "\\"), "");
                            listBox1.Items.Add(name);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
                listBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\r\r" + ex.Message);
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            try
            {




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\r\r" + ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = Source_Folder,
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }
}
