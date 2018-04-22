namespace File_Encryptor_Decryptor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label2 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.targetFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFilesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFilesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encryption Key";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(138, 117);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(175, 20);
            this.keyBox.TabIndex = 2;
            this.keyBox.UseSystemPasswordChar = true;
            this.keyBox.TextChanged += new System.EventHandler(this.keyBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(351, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Key";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // targetFileDialog
            // 
            this.targetFileDialog.InitialDirectory = "D:\\";
            this.targetFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFilesDialog_FileOkClick);
            // 
            // openFilesButton
            // 
            this.openFilesButton.AllowDrop = true;
            this.openFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFilesButton.BackColor = System.Drawing.Color.Transparent;
            this.openFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFilesButton.ForeColor = System.Drawing.Color.White;
            this.openFilesButton.Location = new System.Drawing.Point(170, 41);
            this.openFilesButton.Name = "openFilesButton";
            this.openFilesButton.Size = new System.Drawing.Size(98, 35);
            this.openFilesButton.TabIndex = 4;
            this.openFilesButton.Text = "Open Files";
            this.openFilesButton.UseCompatibleTextRendering = true;
            this.openFilesButton.UseVisualStyleBackColor = false;
            this.openFilesButton.Click += new System.EventHandler(this.openFileButtonClick);
            this.openFilesButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.button1_DragDrop);
            this.openFilesButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.button1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // saveFilesButton
            // 
            this.saveFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveFilesButton.BackColor = System.Drawing.Color.Transparent;
            this.saveFilesButton.Enabled = false;
            this.saveFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFilesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveFilesButton.Location = new System.Drawing.Point(170, 184);
            this.saveFilesButton.Name = "saveFilesButton";
            this.saveFilesButton.Size = new System.Drawing.Size(98, 35);
            this.saveFilesButton.TabIndex = 6;
            this.saveFilesButton.Text = "Save Files";
            this.saveFilesButton.UseVisualStyleBackColor = false;
            this.saveFilesButton.Click += new System.EventHandler(this.saveFileButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(157, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Made By Gil Mansharov";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(157, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Made By Gil Mansharov";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(445, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveFilesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFilesButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(461, 297);
            this.MinimumSize = new System.Drawing.Size(461, 297);
            this.Name = "Form1";
            this.Text = "File Encryptor-Decryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog targetFileDialog;
        private System.Windows.Forms.Button openFilesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveFilesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog destinationFolderDialog;
        private System.Windows.Forms.Label label4;
    }
}

