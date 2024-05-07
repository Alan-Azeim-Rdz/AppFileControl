namespace AppFileControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectFolder = new Button();
            btnProcessFolder = new Button();
            btnOpenTextFile = new Button();
            btnSaveTextFile = new Button();
            TextSave = new Button();
            txtFolder = new TextBox();
            txtProcessFileNumber = new TextBox();
            TxtContent = new TextBox();
            lstvData = new ListView();
            BtnDataSave = new Button();
            combxOption = new ComboBox();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Segoe UI", 20F);
            btnSelectFolder.Location = new Point(13, 23);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(190, 40);
            btnSelectFolder.TabIndex = 0;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // btnProcessFolder
            // 
            btnProcessFolder.Font = new Font("Segoe UI", 20F);
            btnProcessFolder.Location = new Point(13, 79);
            btnProcessFolder.Name = "btnProcessFolder";
            btnProcessFolder.Size = new Size(201, 49);
            btnProcessFolder.TabIndex = 1;
            btnProcessFolder.Text = "process Folder";
            btnProcessFolder.UseVisualStyleBackColor = true;
            btnProcessFolder.Click += btnProcessFolder_Click;
            // 
            // btnOpenTextFile
            // 
            btnOpenTextFile.Font = new Font("Segoe UI", 13F);
            btnOpenTextFile.Location = new Point(27, 144);
            btnOpenTextFile.Name = "btnOpenTextFile";
            btnOpenTextFile.Size = new Size(212, 39);
            btnOpenTextFile.TabIndex = 2;
            btnOpenTextFile.Text = "Open Text File";
            btnOpenTextFile.UseVisualStyleBackColor = true;
            btnOpenTextFile.Click += btnOpenTextFile_Click;
            // 
            // btnSaveTextFile
            // 
            btnSaveTextFile.Font = new Font("Segoe UI", 13F);
            btnSaveTextFile.Location = new Point(261, 143);
            btnSaveTextFile.Name = "btnSaveTextFile";
            btnSaveTextFile.Size = new Size(209, 40);
            btnSaveTextFile.TabIndex = 3;
            btnSaveTextFile.Text = "Save Text File";
            btnSaveTextFile.UseVisualStyleBackColor = true;
            btnSaveTextFile.Click += btnSaveTextFile_Click;
            // 
            // TextSave
            // 
            TextSave.Font = new Font("Segoe UI", 13F);
            TextSave.Location = new Point(738, 36);
            TextSave.Name = "TextSave";
            TextSave.Size = new Size(157, 53);
            TextSave.TabIndex = 4;
            TextSave.Text = "Save Word Text";
            TextSave.UseVisualStyleBackColor = true;
            TextSave.Click += TextSave_Click;
            // 
            // txtFolder
            // 
            txtFolder.Font = new Font("Segoe UI", 20F);
            txtFolder.Location = new Point(209, 23);
            txtFolder.Multiline = true;
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.ScrollBars = ScrollBars.Both;
            txtFolder.Size = new Size(495, 40);
            txtFolder.TabIndex = 5;
            // 
            // txtProcessFileNumber
            // 
            txtProcessFileNumber.Font = new Font("Segoe UI", 20F);
            txtProcessFileNumber.Location = new Point(229, 79);
            txtProcessFileNumber.Multiline = true;
            txtProcessFileNumber.Name = "txtProcessFileNumber";
            txtProcessFileNumber.ReadOnly = true;
            txtProcessFileNumber.ScrollBars = ScrollBars.Both;
            txtProcessFileNumber.Size = new Size(475, 40);
            txtProcessFileNumber.TabIndex = 6;
            // 
            // TxtContent
            // 
            TxtContent.Location = new Point(12, 207);
            TxtContent.Multiline = true;
            TxtContent.Name = "TxtContent";
            TxtContent.ScrollBars = ScrollBars.Vertical;
            TxtContent.Size = new Size(458, 385);
            TxtContent.TabIndex = 7;
            // 
            // lstvData
            // 
            lstvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvData.Location = new Point(497, 207);
            lstvData.Name = "lstvData";
            lstvData.Size = new Size(415, 385);
            lstvData.TabIndex = 8;
            lstvData.UseCompatibleStateImageBehavior = false;
            // 
            // BtnDataSave
            // 
            BtnDataSave.Location = new Point(738, 143);
            BtnDataSave.Name = "BtnDataSave";
            BtnDataSave.Size = new Size(134, 40);
            BtnDataSave.TabIndex = 9;
            BtnDataSave.Text = "Data Save";
            BtnDataSave.UseVisualStyleBackColor = true;
            BtnDataSave.Click += BtnDataSave_Click;
            // 
            // combxOption
            // 
            combxOption.FormattingEnabled = true;
            combxOption.Items.AddRange(new object[] { "Iconos Grandes", "Iconos Pequeños", "Titulos", "Lista" });
            combxOption.Location = new Point(573, 160);
            combxOption.Name = "combxOption";
            combxOption.Size = new Size(121, 23);
            combxOption.TabIndex = 10;
            combxOption.SelectedIndexChanged += combxOption_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 604);
            Controls.Add(combxOption);
            Controls.Add(BtnDataSave);
            Controls.Add(lstvData);
            Controls.Add(TxtContent);
            Controls.Add(txtProcessFileNumber);
            Controls.Add(txtFolder);
            Controls.Add(TextSave);
            Controls.Add(btnSaveTextFile);
            Controls.Add(btnOpenTextFile);
            Controls.Add(btnProcessFolder);
            Controls.Add(btnSelectFolder);
            Name = "Form1";
            Text = "lstvData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFolder;
        private Button btnProcessFolder;
        private Button btnOpenTextFile;
        private Button btnSaveTextFile;
        private Button TextSave;
        private TextBox txtFolder;
        private TextBox txtProcessFileNumber;
        private TextBox TxtContent;
        private ListView lstvData;
        private Button BtnDataSave;
        private ComboBox combxOption;
    }
}
