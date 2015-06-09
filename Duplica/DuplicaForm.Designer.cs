namespace Duplica
{
    partial class DuplicaForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Duplica.Format format1 = new Duplica.Format();
            Duplica.Format format2 = new Duplica.Format();
            this.FileListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.fileLengthBox = new System.Windows.Forms.GroupBox();
            this.minSizeLabel = new System.Windows.Forms.Label();
            this.minSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.skipPathsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeSkipPathButton = new System.Windows.Forms.Button();
            this.addSkipPathButton = new System.Windows.Forms.Button();
            this.skipPathsListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.pathsGroupBox = new System.Windows.Forms.GroupBox();
            this.removePathButton = new System.Windows.Forms.Button();
            this.addPathButton = new System.Windows.Forms.Button();
            this.pathsListBox = new System.Windows.Forms.ListBox();
            this.choosePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.maxSizeLabel = new System.Windows.Forms.Label();
            this.maxSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.minSizeComboBox = new System.Windows.Forms.ComboBox();
            this.duplicateLister = new Duplica.CustomForms.CustomListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skipPathsDescriptionBox = new Duplica.RichTextBoxEx();
            this.pathsDescriptionBox = new Duplica.RichTextBoxEx();
            this.maxSizeComboBox = new System.Windows.Forms.ComboBox();
            this.FileListContextMenu.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.fileLengthBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minSizeUpDown)).BeginInit();
            this.skipPathsGroupBox.SuspendLayout();
            this.pathsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FileListContextMenu
            // 
            this.FileListContextMenu.AccessibleDescription = "sfd";
            this.FileListContextMenu.AccessibleName = "sfd";
            this.FileListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileListToolStripMenuItem,
            this.kopierenToolStripMenuItem});
            this.FileListContextMenu.Name = "contextMenuStrip1";
            this.FileListContextMenu.Size = new System.Drawing.Size(122, 48);
            // 
            // fileListToolStripMenuItem
            // 
            this.fileListToolStripMenuItem.Name = "fileListToolStripMenuItem";
            this.fileListToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.fileListToolStripMenuItem.Text = "Öffnen";
            this.fileListToolStripMenuItem.Click += new System.EventHandler(this.OpenSelectedEntry);
            // 
            // kopierenToolStripMenuItem
            // 
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kopierenToolStripMenuItem.Text = "Kopieren";
            this.kopierenToolStripMenuItem.Click += new System.EventHandler(this.kopierenToolStripMenuItem_Click);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.fileLengthBox);
            this.optionsPanel.Controls.Add(this.skipPathsGroupBox);
            this.optionsPanel.Controls.Add(this.okButton);
            this.optionsPanel.Controls.Add(this.pathsGroupBox);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsPanel.Location = new System.Drawing.Point(10, 10);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(954, 216);
            this.optionsPanel.TabIndex = 4;
            // 
            // fileLengthBox
            // 
            this.fileLengthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLengthBox.Controls.Add(this.maxSizeComboBox);
            this.fileLengthBox.Controls.Add(this.minSizeComboBox);
            this.fileLengthBox.Controls.Add(this.maxSizeUpDown);
            this.fileLengthBox.Controls.Add(this.maxSizeLabel);
            this.fileLengthBox.Controls.Add(this.minSizeLabel);
            this.fileLengthBox.Controls.Add(this.minSizeUpDown);
            this.fileLengthBox.Location = new System.Drawing.Point(673, 3);
            this.fileLengthBox.Name = "fileLengthBox";
            this.fileLengthBox.Size = new System.Drawing.Size(278, 75);
            this.fileLengthBox.TabIndex = 8;
            this.fileLengthBox.TabStop = false;
            this.fileLengthBox.Text = "Dateigrösse filtern";
            // 
            // minSizeLabel
            // 
            this.minSizeLabel.AutoSize = true;
            this.minSizeLabel.Location = new System.Drawing.Point(6, 19);
            this.minSizeLabel.Name = "minSizeLabel";
            this.minSizeLabel.Size = new System.Drawing.Size(87, 13);
            this.minSizeLabel.TabIndex = 2;
            this.minSizeLabel.Text = "Minimale Grösse:";
            // 
            // minSizeUpDown
            // 
            this.minSizeUpDown.Location = new System.Drawing.Point(109, 17);
            this.minSizeUpDown.Name = "minSizeUpDown";
            this.minSizeUpDown.Size = new System.Drawing.Size(99, 20);
            this.minSizeUpDown.TabIndex = 1;
            // 
            // skipPathsGroupBox
            // 
            this.skipPathsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipPathsGroupBox.Controls.Add(this.skipPathsDescriptionBox);
            this.skipPathsGroupBox.Controls.Add(this.removeSkipPathButton);
            this.skipPathsGroupBox.Controls.Add(this.addSkipPathButton);
            this.skipPathsGroupBox.Controls.Add(this.skipPathsListBox);
            this.skipPathsGroupBox.Location = new System.Drawing.Point(3, 109);
            this.skipPathsGroupBox.Name = "skipPathsGroupBox";
            this.skipPathsGroupBox.Size = new System.Drawing.Size(664, 100);
            this.skipPathsGroupBox.TabIndex = 7;
            this.skipPathsGroupBox.TabStop = false;
            this.skipPathsGroupBox.Text = "Zu durchsuchende Dateipfade";
            // 
            // removeSkipPathButton
            // 
            this.removeSkipPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSkipPathButton.Location = new System.Drawing.Point(574, 67);
            this.removeSkipPathButton.Name = "removeSkipPathButton";
            this.removeSkipPathButton.Size = new System.Drawing.Size(84, 23);
            this.removeSkipPathButton.TabIndex = 4;
            this.removeSkipPathButton.Text = "Entfernen";
            this.removeSkipPathButton.UseVisualStyleBackColor = true;
            this.removeSkipPathButton.Click += new System.EventHandler(this.removeSkipPathButton_Click);
            // 
            // addSkipPathButton
            // 
            this.addSkipPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSkipPathButton.Location = new System.Drawing.Point(574, 38);
            this.addSkipPathButton.Name = "addSkipPathButton";
            this.addSkipPathButton.Size = new System.Drawing.Size(84, 23);
            this.addSkipPathButton.TabIndex = 3;
            this.addSkipPathButton.Text = "Hinzufügen";
            this.addSkipPathButton.UseVisualStyleBackColor = true;
            this.addSkipPathButton.Click += new System.EventHandler(this.addSkipPathButton_Click);
            // 
            // skipPathsListBox
            // 
            this.skipPathsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipPathsListBox.FormattingEnabled = true;
            this.skipPathsListBox.Location = new System.Drawing.Point(6, 38);
            this.skipPathsListBox.Name = "skipPathsListBox";
            this.skipPathsListBox.Size = new System.Drawing.Size(562, 56);
            this.skipPathsListBox.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(876, 190);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Los!";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // pathsGroupBox
            // 
            this.pathsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathsGroupBox.Controls.Add(this.pathsDescriptionBox);
            this.pathsGroupBox.Controls.Add(this.removePathButton);
            this.pathsGroupBox.Controls.Add(this.addPathButton);
            this.pathsGroupBox.Controls.Add(this.pathsListBox);
            this.pathsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.pathsGroupBox.Name = "pathsGroupBox";
            this.pathsGroupBox.Size = new System.Drawing.Size(664, 100);
            this.pathsGroupBox.TabIndex = 1;
            this.pathsGroupBox.TabStop = false;
            this.pathsGroupBox.Text = "Zu durchsuchende Dateipfade";
            // 
            // removePathButton
            // 
            this.removePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removePathButton.Location = new System.Drawing.Point(574, 67);
            this.removePathButton.Name = "removePathButton";
            this.removePathButton.Size = new System.Drawing.Size(84, 23);
            this.removePathButton.TabIndex = 4;
            this.removePathButton.Text = "Entfernen";
            this.removePathButton.UseVisualStyleBackColor = true;
            this.removePathButton.Click += new System.EventHandler(this.removePathButton_Click);
            // 
            // addPathButton
            // 
            this.addPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPathButton.Location = new System.Drawing.Point(574, 38);
            this.addPathButton.Name = "addPathButton";
            this.addPathButton.Size = new System.Drawing.Size(84, 23);
            this.addPathButton.TabIndex = 3;
            this.addPathButton.Text = "Hinzufügen";
            this.addPathButton.UseVisualStyleBackColor = true;
            this.addPathButton.Click += new System.EventHandler(this.addPathButton_Click);
            // 
            // pathsListBox
            // 
            this.pathsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathsListBox.FormattingEnabled = true;
            this.pathsListBox.Items.AddRange(new object[] {
            "M:\\Projekte\\Duplica\\Duplica\\bin\\Debug"});
            this.pathsListBox.Location = new System.Drawing.Point(6, 38);
            this.pathsListBox.Name = "pathsListBox";
            this.pathsListBox.Size = new System.Drawing.Size(562, 56);
            this.pathsListBox.TabIndex = 2;
            // 
            // choosePathDialog
            // 
            this.choosePathDialog.ShowNewFolderButton = false;
            // 
            // maxSizeLabel
            // 
            this.maxSizeLabel.AutoSize = true;
            this.maxSizeLabel.Location = new System.Drawing.Point(6, 47);
            this.maxSizeLabel.Name = "maxSizeLabel";
            this.maxSizeLabel.Size = new System.Drawing.Size(90, 13);
            this.maxSizeLabel.TabIndex = 3;
            this.maxSizeLabel.Text = "Maximale Grösse:";
            // 
            // maxSizeUpDown
            // 
            this.maxSizeUpDown.Location = new System.Drawing.Point(109, 45);
            this.maxSizeUpDown.Name = "maxSizeUpDown";
            this.maxSizeUpDown.Size = new System.Drawing.Size(99, 20);
            this.maxSizeUpDown.TabIndex = 4;
            // 
            // minSizeComboBox
            // 
            this.minSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minSizeComboBox.FormattingEnabled = true;
            this.minSizeComboBox.Items.AddRange(new object[] {
            "MB",
            "KB",
            "Bytes"});
            this.minSizeComboBox.Location = new System.Drawing.Point(214, 16);
            this.minSizeComboBox.Name = "minSizeComboBox";
            this.minSizeComboBox.Size = new System.Drawing.Size(58, 21);
            this.minSizeComboBox.TabIndex = 5;
            // 
            // duplicateLister
            // 
            this.duplicateLister.AllowColumnReorder = true;
            this.duplicateLister.CheckBoxes = true;
            this.duplicateLister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileLength,
            this.FullPath});
            this.duplicateLister.ContextMenuStrip = this.FileListContextMenu;
            this.duplicateLister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duplicateLister.FullRowSelect = true;
            this.duplicateLister.LabelWrap = false;
            this.duplicateLister.Location = new System.Drawing.Point(10, 226);
            this.duplicateLister.Name = "duplicateLister";
            this.duplicateLister.Size = new System.Drawing.Size(954, 370);
            this.duplicateLister.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.duplicateLister.TabIndex = 5;
            this.duplicateLister.UseCompatibleStateImageBehavior = false;
            this.duplicateLister.View = System.Windows.Forms.View.Details;
            this.duplicateLister.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OpenSelectedEntry);
            this.duplicateLister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.duplicateLister_MouseDown);
            // 
            // FileName
            // 
            this.FileName.Name = "FileName";
            this.FileName.Text = "Dateiname";
            this.FileName.Width = 71;
            // 
            // FileLength
            // 
            this.FileLength.Name = "FileLength";
            this.FileLength.Text = "Grösse";
            this.FileLength.Width = 89;
            // 
            // FullPath
            // 
            this.FullPath.Name = "FullPath";
            this.FullPath.Text = "Dateipfad";
            this.FullPath.Width = 555;
            // 
            // skipPathsDescriptionBox
            // 
            this.skipPathsDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skipPathsDescriptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.skipPathsDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skipPathsDescriptionBox.Enabled = false;
            this.skipPathsDescriptionBox.Location = new System.Drawing.Point(6, 19);
            this.skipPathsDescriptionBox.Name = "skipPathsDescriptionBox";
            this.skipPathsDescriptionBox.ReadOnly = true;
            this.skipPathsDescriptionBox.Size = new System.Drawing.Size(652, 13);
            format1.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            format1.BackColor = System.Drawing.SystemColors.Control;
            format1.Bullets = false;
            format1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            format1.ForeColor = System.Drawing.SystemColors.WindowText;
            format1.Indent = 0;
            format1.RightIndent = 0;
            this.skipPathsDescriptionBox.StandardFormat = format1;
            this.skipPathsDescriptionBox.TabIndex = 6;
            this.skipPathsDescriptionBox.Text = "";
            // 
            // pathsDescriptionBox
            // 
            this.pathsDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathsDescriptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.pathsDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathsDescriptionBox.Enabled = false;
            this.pathsDescriptionBox.Location = new System.Drawing.Point(6, 19);
            this.pathsDescriptionBox.Name = "pathsDescriptionBox";
            this.pathsDescriptionBox.ReadOnly = true;
            this.pathsDescriptionBox.Size = new System.Drawing.Size(652, 13);
            format2.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
            format2.BackColor = System.Drawing.SystemColors.Control;
            format2.Bullets = false;
            format2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            format2.ForeColor = System.Drawing.SystemColors.WindowText;
            format2.Indent = 0;
            format2.RightIndent = 0;
            this.pathsDescriptionBox.StandardFormat = format2;
            this.pathsDescriptionBox.TabIndex = 6;
            this.pathsDescriptionBox.Text = "";
            // 
            // maxSizeComboBox
            // 
            this.maxSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxSizeComboBox.FormattingEnabled = true;
            this.maxSizeComboBox.Items.AddRange(new object[] {
            "MB",
            "KB",
            "Bytes"});
            this.maxSizeComboBox.Location = new System.Drawing.Point(214, 44);
            this.maxSizeComboBox.Name = "maxSizeComboBox";
            this.maxSizeComboBox.Size = new System.Drawing.Size(58, 21);
            this.maxSizeComboBox.TabIndex = 6;
            // 
            // DuplicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 606);
            this.Controls.Add(this.duplicateLister);
            this.Controls.Add(this.optionsPanel);
            this.MinimumSize = new System.Drawing.Size(830, 644);
            this.Name = "DuplicaForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Duplica_Load);
            this.FileListContextMenu.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.fileLengthBox.ResumeLayout(false);
            this.fileLengthBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minSizeUpDown)).EndInit();
            this.skipPathsGroupBox.ResumeLayout(false);
            this.pathsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxSizeUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip FileListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem fileListToolStripMenuItem;
        private System.Windows.Forms.Panel optionsPanel;
        private CustomForms.CustomListView duplicateLister;
        private System.Windows.Forms.GroupBox pathsGroupBox;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileLength;
        private System.Windows.Forms.ColumnHeader FullPath;
        private System.Windows.Forms.ListBox pathsListBox;
        private System.Windows.Forms.Button removePathButton;
        private System.Windows.Forms.FolderBrowserDialog choosePathDialog;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ToolTip toolTip;
        private RichTextBoxEx pathsDescriptionBox;
        private System.Windows.Forms.GroupBox skipPathsGroupBox;
        private RichTextBoxEx skipPathsDescriptionBox;
        private System.Windows.Forms.Button removeSkipPathButton;
        private System.Windows.Forms.Button addSkipPathButton;
        private System.Windows.Forms.ListBox skipPathsListBox;
        private System.Windows.Forms.Button addPathButton;
        private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem;
        private System.Windows.Forms.GroupBox fileLengthBox;
        private System.Windows.Forms.Label minSizeLabel;
        private System.Windows.Forms.NumericUpDown minSizeUpDown;
        private System.Windows.Forms.Label maxSizeLabel;
        private System.Windows.Forms.NumericUpDown maxSizeUpDown;
        private System.Windows.Forms.ComboBox minSizeComboBox;
        private System.Windows.Forms.ComboBox maxSizeComboBox;




    }
}

