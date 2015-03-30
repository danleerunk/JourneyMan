namespace JourneyMan
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Images = new System.Windows.Forms.DataGridViewImageColumn();
            this.UnderPicText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateRightButton = new System.Windows.Forms.Button();
            this.rotateLeftButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.moveRowDownButton = new System.Windows.Forms.Button();
            this.moveRowUpButton = new System.Windows.Forms.Button();
            this.addImagesButton = new System.Windows.Forms.Button();
            this.imageLoadDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.loadSavedDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveProgressDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Images,
            this.UnderPicText,
            this.ImageNotes});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(685, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Images
            // 
            this.Images.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Images.DefaultCellStyle = dataGridViewCellStyle3;
            this.Images.HeaderText = "Images";
            this.Images.MinimumWidth = 47;
            this.Images.Name = "Images";
            this.Images.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Images.ToolTipText = "Images are show in this column";
            this.Images.Width = 47;
            // 
            // UnderPicText
            // 
            this.UnderPicText.HeaderText = "Text Under Image";
            this.UnderPicText.MinimumWidth = 200;
            this.UnderPicText.Name = "UnderPicText";
            this.UnderPicText.ToolTipText = "Text entered here will be displayed below the image";
            this.UnderPicText.Width = 300;
            // 
            // ImageNotes
            // 
            this.ImageNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImageNotes.HeaderText = "Notes";
            this.ImageNotes.MinimumWidth = 100;
            this.ImageNotes.Name = "ImageNotes";
            this.ImageNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ImageNotes.ToolTipText = "Text entered here will be displayed to the left of the image";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rotateRightButton);
            this.splitContainer1.Panel2.Controls.Add(this.rotateLeftButton);
            this.splitContainer1.Panel2.Controls.Add(this.publishButton);
            this.splitContainer1.Panel2.Controls.Add(this.removeButton);
            this.splitContainer1.Panel2.Controls.Add(this.moveRowDownButton);
            this.splitContainer1.Panel2.Controls.Add(this.moveRowUpButton);
            this.splitContainer1.Panel2.Controls.Add(this.addImagesButton);
            this.splitContainer1.Size = new System.Drawing.Size(685, 395);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuHelp,
            this.toolStripMenuClear});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.loadToolStripMenuItem.Text = "Load Saved Progress...";
            this.loadToolStripMenuItem.ToolTipText = "Load a saved Journey file";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.saveToolStripMenuItem.Text = "Save Progress...";
            this.saveToolStripMenuItem.ToolTipText = "Save current progress";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuHelp
            // 
            this.toolStripMenuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuHelp.Name = "toolStripMenuHelp";
            this.toolStripMenuHelp.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuHelp.Text = "Help!";
            this.toolStripMenuHelp.ToolTipText = "Get you some help";
            this.toolStripMenuHelp.Click += new System.EventHandler(this.toolStripMenuHelp_Click);
            // 
            // toolStripMenuClear
            // 
            this.toolStripMenuClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuClear.Name = "toolStripMenuClear";
            this.toolStripMenuClear.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuClear.Text = "Clear All";
            this.toolStripMenuClear.ToolTipText = "Clear all current data";
            this.toolStripMenuClear.Click += new System.EventHandler(this.toolStripMenuClear_Click);
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateRightButton.Location = new System.Drawing.Point(219, 10);
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(34, 45);
            this.rotateRightButton.TabIndex = 11;
            this.rotateRightButton.Text = ">";
            this.rotateRightButton.UseVisualStyleBackColor = true;
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateLeftButton.Location = new System.Drawing.Point(179, 10);
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(34, 45);
            this.rotateLeftButton.TabIndex = 10;
            this.rotateLeftButton.Text = "<";
            this.rotateLeftButton.UseVisualStyleBackColor = true;
            this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
            // 
            // publishButton
            // 
            this.publishButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publishButton.Location = new System.Drawing.Point(581, 9);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(92, 45);
            this.publishButton.TabIndex = 9;
            this.publishButton.Text = "Publish Update";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(94, 10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 45);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove Row";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // moveRowDownButton
            // 
            this.moveRowDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moveRowDownButton.Location = new System.Drawing.Point(51, 10);
            this.moveRowDownButton.Name = "moveRowDownButton";
            this.moveRowDownButton.Size = new System.Drawing.Size(34, 45);
            this.moveRowDownButton.TabIndex = 3;
            this.moveRowDownButton.Text = "˅";
            this.moveRowDownButton.UseVisualStyleBackColor = true;
            this.moveRowDownButton.Click += new System.EventHandler(this.moveRowDownButton_Click);
            // 
            // moveRowUpButton
            // 
            this.moveRowUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.moveRowUpButton.Location = new System.Drawing.Point(11, 10);
            this.moveRowUpButton.Name = "moveRowUpButton";
            this.moveRowUpButton.Size = new System.Drawing.Size(34, 45);
            this.moveRowUpButton.TabIndex = 2;
            this.moveRowUpButton.Text = "˄";
            this.moveRowUpButton.UseVisualStyleBackColor = true;
            this.moveRowUpButton.Click += new System.EventHandler(this.moveRowUpButton_Click);
            // 
            // addImagesButton
            // 
            this.addImagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addImagesButton.Location = new System.Drawing.Point(358, 9);
            this.addImagesButton.Name = "addImagesButton";
            this.addImagesButton.Size = new System.Drawing.Size(119, 45);
            this.addImagesButton.TabIndex = 1;
            this.addImagesButton.Text = "Add Image(s)";
            this.addImagesButton.UseVisualStyleBackColor = true;
            this.addImagesButton.Click += new System.EventHandler(this.addImagesButton_Click);
            // 
            // imageLoadDialog
            // 
            this.imageLoadDialog.FileName = "Select Images...";
            this.imageLoadDialog.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF| All files (*.*)|*.*";
            this.imageLoadDialog.Multiselect = true;
            this.imageLoadDialog.Title = "Select Image FIles...";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose a folder in which to save this update. A subfolder will be created there, " +
    "named using the date you chose for your update.";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // loadSavedDialog
            // 
            this.loadSavedDialog.Filter = "JourneyMan save file|*.jmn|All files|*.*";
            this.loadSavedDialog.Multiselect = true;
            this.loadSavedDialog.Title = "Load JourneyMan Save";
            // 
            // saveProgressDialog
            // 
            this.saveProgressDialog.DefaultExt = "jnm";
            this.saveProgressDialog.Filter = "JourneyMan save file|*.jmn|All files|*.*";
            this.saveProgressDialog.Title = "Save progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 395);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(505, 273);
            this.Name = "Form1";
            this.Text = "JourneyMan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addImagesButton;
        private System.Windows.Forms.OpenFileDialog imageLoadDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button moveRowDownButton;
        private System.Windows.Forms.Button moveRowUpButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.OpenFileDialog loadSavedDialog;
        private System.Windows.Forms.SaveFileDialog saveProgressDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClear;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelp;
        private System.Windows.Forms.Button rotateRightButton;
        private System.Windows.Forms.Button rotateLeftButton;
        private System.Windows.Forms.DataGridViewImageColumn Images;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnderPicText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageNotes;
    }
}

