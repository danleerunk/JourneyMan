namespace JourneyMan
{
    partial class PublishForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishForm));
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publishPUButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.zipFileCheckbox = new System.Windows.Forms.CheckBox();
            this.kristinModeCheckbox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "640",
            "800",
            "1024"});
            this.sizeComboBox.Location = new System.Drawing.Point(34, 68);
            this.sizeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(298, 28);
            this.sizeComboBox.TabIndex = 6;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Image Width (pixels):";
            // 
            // publishPUButton
            // 
            this.publishPUButton.Location = new System.Drawing.Point(110, 574);
            this.publishPUButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.publishPUButton.Name = "publishPUButton";
            this.publishPUButton.Size = new System.Drawing.Size(136, 54);
            this.publishPUButton.TabIndex = 8;
            this.publishPUButton.Text = "Publish!";
            this.publishPUButton.UseVisualStyleBackColor = true;
            this.publishPUButton.Click += new System.EventHandler(this.publishPUButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 268);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 374);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 113);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chose the date for this update:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter text for page header (optional):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(34, 163);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(300, 26);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Select Image Quality:";
            // 
            // zipFileCheckbox
            // 
            this.zipFileCheckbox.AutoSize = true;
            this.zipFileCheckbox.Location = new System.Drawing.Point(36, 522);
            this.zipFileCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipFileCheckbox.Name = "zipFileCheckbox";
            this.zipFileCheckbox.Size = new System.Drawing.Size(138, 24);
            this.zipFileCheckbox.TabIndex = 15;
            this.zipFileCheckbox.Text = "Create Zip File";
            this.zipFileCheckbox.UseVisualStyleBackColor = true;
            // 
            // kristinModeCheckbox
            // 
            this.kristinModeCheckbox.AutoSize = true;
            this.kristinModeCheckbox.Location = new System.Drawing.Point(208, 522);
            this.kristinModeCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kristinModeCheckbox.Name = "kristinModeCheckbox";
            this.kristinModeCheckbox.Size = new System.Drawing.Size(122, 24);
            this.kristinModeCheckbox.TabIndex = 17;
            this.kristinModeCheckbox.Text = "Kristin Mode";
            this.kristinModeCheckbox.UseVisualStyleBackColor = true;
            this.kristinModeCheckbox.CheckedChanged += new System.EventHandler(this.kristinModeCheckbox_CheckedChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose a folder in which to save this update. A subfolder will be created there, " +
    "named using the date you chose for your update.";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // PublishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 663);
            this.Controls.Add(this.kristinModeCheckbox);
            this.Controls.Add(this.zipFileCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.publishPUButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeComboBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublishForm";
            this.Text = "Publishing Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button publishPUButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox zipFileCheckbox;
        private System.Windows.Forms.CheckBox kristinModeCheckbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}