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
            this.toggleGroupsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openMI = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyMI = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.fileLengthBox = new System.Windows.Forms.GroupBox();
            this.maxSizeLabel = new System.Windows.Forms.Label();
            this.minSizeLabel = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.duplicateLister = new Duplica.CustomForms.CustomListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxSizeUnitBox = new Duplica.CustomForms.FileSizeUnitBox();
            this.minSizeUnitBox = new Duplica.CustomForms.FileSizeUnitBox();
            this.skipPathsDescriptionBox = new Duplica.RichTextBoxEx();
            this.pathsDescriptionBox = new Duplica.RichTextBoxEx();
            this.FileListContextMenu.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.fileLengthBox.SuspendLayout();
            this.skipPathsGroupBox.SuspendLayout();
            this.pathsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileListContextMenu
            // 
            this.FileListContextMenu.AccessibleDescription = "sfd";
            this.FileListContextMenu.AccessibleName = "sfd";
            this.FileListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleGroupsMI,
            this.toolStripSeparator1,
            this.openMI,
            this.explorerMI,
            this.toolStripSeparator2,
            this.copyMI});
            this.FileListContextMenu.Name = "contextMenuStrip1";
            this.FileListContextMenu.Size = new System.Drawing.Size(184, 104);
            // 
            // toggleGroupsMI
            // 
            this.toggleGroupsMI.Checked = true;
            this.toggleGroupsMI.CheckOnClick = true;
            this.toggleGroupsMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleGroupsMI.Name = "toggleGroupsMI";
            this.toggleGroupsMI.Size = new System.Drawing.Size(183, 22);
            this.toggleGroupsMI.Text = "Gruppieren";
            this.toggleGroupsMI.CheckedChanged += new System.EventHandler(this.toggleGroupsMI_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // openMI
            // 
            this.openMI.Name = "openMI";
            this.openMI.Size = new System.Drawing.Size(183, 22);
            this.openMI.Text = "Öffnen";
            this.openMI.Click += new System.EventHandler(this.OpenSelectedEntry);
            // 
            // explorerMI
            // 
            this.explorerMI.Name = "explorerMI";
            this.explorerMI.Size = new System.Drawing.Size(183, 22);
            this.explorerMI.Text = "Im Explorer anzeigen";
            this.explorerMI.Click += new System.EventHandler(this.explorerMI_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // copyMI
            // 
            this.copyMI.Name = "copyMI";
            this.copyMI.Size = new System.Drawing.Size(183, 22);
            this.copyMI.Text = "Kopieren";
            this.copyMI.Click += new System.EventHandler(this.copyMI_Click);
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
            this.fileLengthBox.Controls.Add(this.maxSizeUnitBox);
            this.fileLengthBox.Controls.Add(this.minSizeUnitBox);
            this.fileLengthBox.Controls.Add(this.maxSizeLabel);
            this.fileLengthBox.Controls.Add(this.minSizeLabel);
            this.fileLengthBox.Location = new System.Drawing.Point(673, 3);
            this.fileLengthBox.Name = "fileLengthBox";
            this.fileLengthBox.Size = new System.Drawing.Size(278, 75);
            this.fileLengthBox.TabIndex = 8;
            this.fileLengthBox.TabStop = false;
            this.fileLengthBox.Text = "Dateigrösse filtern";
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
            // minSizeLabel
            // 
            this.minSizeLabel.AutoSize = true;
            this.minSizeLabel.Location = new System.Drawing.Point(6, 19);
            this.minSizeLabel.Name = "minSizeLabel";
            this.minSizeLabel.Size = new System.Drawing.Size(87, 13);
            this.minSizeLabel.TabIndex = 2;
            this.minSizeLabel.Text = "Minimale Grösse:";
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
            this.skipPathsGroupBox.Text = "Auszuschliessende Dateipfade";
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
            this.pathsListBox.Location = new System.Drawing.Point(6, 38);
            this.pathsListBox.Name = "pathsListBox";
            this.pathsListBox.Size = new System.Drawing.Size(562, 56);
            this.pathsListBox.TabIndex = 2;
            // 
            // choosePathDialog
            // 
            this.choosePathDialog.ShowNewFolderButton = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 565);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 31);
            this.panel1.TabIndex = 6;
            // 
            // duplicateLister
            // 
            this.duplicateLister.AllowColumnReorder = true;
            this.duplicateLister.CheckBoxes = true;
            this.duplicateLister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.fileSize,
            this.fullPath});
            this.duplicateLister.ContextMenuStrip = this.FileListContextMenu;
            this.duplicateLister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.duplicateLister.FullRowSelect = true;
            this.duplicateLister.LabelWrap = false;
            this.duplicateLister.Location = new System.Drawing.Point(10, 226);
            this.duplicateLister.Name = "duplicateLister";
            this.duplicateLister.Size = new System.Drawing.Size(954, 339);
            this.duplicateLister.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.duplicateLister.TabIndex = 7;
            this.duplicateLister.UseCompatibleStateImageBehavior = false;
            this.duplicateLister.View = System.Windows.Forms.View.Details;
            this.duplicateLister.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.duplicateLister_ColumnClick);
            this.duplicateLister.ItemActivate += new System.EventHandler(this.duplicateLister_ItemActivate);
            this.duplicateLister.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.duplicateLister_ItemDrag);
            // 
            // fileName
            // 
            this.fileName.Name = "fileName";
            this.fileName.Text = "Dateiname";
            this.fileName.Width = 71;
            // 
            // fileSize
            // 
            this.fileSize.Name = "fileSize";
            this.fileSize.Text = "Grösse";
            this.fileSize.Width = 89;
            // 
            // fullPath
            // 
            this.fullPath.Name = "fullPath";
            this.fullPath.Text = "Dateipfad";
            this.fullPath.Width = 555;
            // 
            // maxSizeUnitBox
            // 
            this.maxSizeUnitBox.Location = new System.Drawing.Point(109, 44);
            this.maxSizeUnitBox.Name = "maxSizeUnitBox";
            this.maxSizeUnitBox.SelectedIndex = 0;
            this.maxSizeUnitBox.Size = new System.Drawing.Size(163, 21);
            this.maxSizeUnitBox.TabIndex = 5;
            // 
            // minSizeUnitBox
            // 
            this.minSizeUnitBox.Location = new System.Drawing.Point(109, 18);
            this.minSizeUnitBox.Name = "minSizeUnitBox";
            this.minSizeUnitBox.SelectedIndex = 0;
            this.minSizeUnitBox.Size = new System.Drawing.Size(163, 21);
            this.minSizeUnitBox.TabIndex = 4;
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
            // DuplicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 606);
            this.Controls.Add(this.duplicateLister);
            this.Controls.Add(this.panel1);
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
            this.skipPathsGroupBox.ResumeLayout(false);
            this.pathsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip FileListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openMI;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.GroupBox pathsGroupBox;
        private System.Windows.Forms.ListBox pathsListBox;
        private System.Windows.Forms.Button removePathButton;
        private System.Windows.Forms.FolderBrowserDialog choosePathDialog;
        private System.Windows.Forms.Button okButton;
        private RichTextBoxEx pathsDescriptionBox;
        private System.Windows.Forms.GroupBox skipPathsGroupBox;
        private RichTextBoxEx skipPathsDescriptionBox;
        private System.Windows.Forms.Button removeSkipPathButton;
        private System.Windows.Forms.Button addSkipPathButton;
        private System.Windows.Forms.ListBox skipPathsListBox;
        private System.Windows.Forms.Button addPathButton;
        private System.Windows.Forms.ToolStripMenuItem copyMI;
        private System.Windows.Forms.GroupBox fileLengthBox;
        private System.Windows.Forms.Label minSizeLabel;
        private System.Windows.Forms.Label maxSizeLabel;
        private CustomForms.FileSizeUnitBox minSizeUnitBox;
        private CustomForms.FileSizeUnitBox maxSizeUnitBox;
        private System.Windows.Forms.ToolStripMenuItem explorerMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader fullPath;
        private System.Windows.Forms.ColumnHeader fileSize;
        private System.Windows.Forms.ColumnHeader fileName;
        private CustomForms.CustomListView duplicateLister;
        private System.Windows.Forms.ToolStripMenuItem toggleGroupsMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

