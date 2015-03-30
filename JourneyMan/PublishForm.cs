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

namespace JourneyMan
{
    public partial class PublishForm : Form
    {
        Form1 mainForm;

        public PublishForm(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.sizeComboBox.SelectedIndex = 0;

            // Trying to save defaults for set size and quality
            string runningPath = Directory.GetCurrentDirectory().ToString();
            if (!File.Exists(runningPath + "\\jmnconfig.cfg"))
            {
                StreamWriter configWriter = new StreamWriter(runningPath + "\\jmnconfig.cfg");
                configWriter.WriteLine("Image Size " + sizeComboBox.SelectedIndex);
                configWriter.WriteLine("Quality " + numericUpDown1.Value);
                configWriter.Close();
            }
            else
            {
                StreamReader configReader = new StreamReader(runningPath + "\\jmnconfig.cfg");
                while (!configReader.EndOfStream)
                {
                    string line = configReader.ReadLine();
                    if (line.StartsWith("Image"))
                    {
                        string size = line.Substring(11);
                        sizeComboBox.SelectedIndex = Convert.ToInt32(size);
                    }
                    if (line.StartsWith("Quality"))
                    {
                        string quality = line.Substring(8);
                        numericUpDown1.Value = Convert.ToInt32(quality);
                    }
                }
                configReader.Close();
            }

        }

        private void publishPUButton_Click(object sender, EventArgs e)
        {
            bool kState = this.kristinModeCheckbox.CheckState == CheckState.Checked ? true : false;
            bool zipState = this.zipFileCheckbox.CheckState == CheckState.Checked ? true : false;
            
            if (mainForm.publish(this.dateTimePicker1.Value, textBox1.Text, Convert.ToInt64(numericUpDown1.Value), kState, zipState) == true)
            {
                mainForm.clearAll(1);
            }
            string runningPath = Directory.GetCurrentDirectory().ToString();
            StreamWriter configWriter = new StreamWriter(runningPath + "\\jmnconfig.cfg");
            configWriter.WriteLine("Image Size " + sizeComboBox.SelectedIndex);
            configWriter.WriteLine("Quality " + numericUpDown1.Value);
            configWriter.Close();

            this.Close(); 
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This should change the ratio by which the photo is reduced for publishing
            switch (sizeComboBox.SelectedIndex)
            {
                case 0:
                    mainForm.reduceImageWidthTo = 640;
                    break;
                case 1:
                    mainForm.reduceImageWidthTo = 800;
                    break;
                case 2:
                    mainForm.reduceImageWidthTo = 1024;
                    break;
                default:
                    break;
            }
        }

        private void kristinModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.kristinModeCheckbox.Checked)
            {
                this.zipFileCheckbox.Checked = false;
            }
        }
    }
}
