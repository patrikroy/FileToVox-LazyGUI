namespace FileToVox_LazyGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_pasteAdvice = new System.Windows.Forms.Label();
            this.label_ver = new System.Windows.Forms.Label();
            this.button_cc = new System.Windows.Forms.Button();
            this.label_step5 = new System.Windows.Forms.Label();
            this.label_step4 = new System.Windows.Forms.Label();
            this.textBox_outputCmd = new System.Windows.Forms.TextBox();
            this.textBox_f2vPath = new System.Windows.Forms.TextBox();
            this.label_file2VoxPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog_outputfile = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog_inputfile = new System.Windows.Forms.OpenFileDialog();
            this.label_title = new System.Windows.Forms.Label();
            this.button_cmd = new System.Windows.Forms.Button();
            this.label_outputPath = new System.Windows.Forms.Label();
            this.textBox_outputFile = new System.Windows.Forms.TextBox();
            this.textBox_inputFile = new System.Windows.Forms.TextBox();
            this.label_inputfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(508, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(318, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "MagicaVoxel Community";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(421, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "LazyGUI by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(430, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 30;
            this.label1.Text = "FileToVox by";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel4.LinkColor = System.Drawing.Color.Red;
            this.linkLabel4.Location = new System.Drawing.Point(517, 244);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(36, 16);
            this.linkLabel4.TabIndex = 29;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Wiki";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWiki_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel3.LinkColor = System.Drawing.Color.Red;
            this.linkLabel3.Location = new System.Drawing.Point(456, 244);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(55, 16);
            this.linkLabel3.TabIndex = 28;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Discord";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDiscord_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(484, 217);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 16);
            this.linkLabel2.TabIndex = 27;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "PatrikRoy";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPatrik_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(502, 189);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 16);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Zarbuz";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkZarbuz_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label_pasteAdvice
            // 
            this.label_pasteAdvice.AutoSize = true;
            this.label_pasteAdvice.Location = new System.Drawing.Point(13, 237);
            this.label_pasteAdvice.Name = "label_pasteAdvice";
            this.label_pasteAdvice.Size = new System.Drawing.Size(207, 13);
            this.label_pasteAdvice.TabIndex = 24;
            this.label_pasteAdvice.Text = "6 - Paste in cmd.exe using mouse RButton";
            // 
            // label_ver
            // 
            this.label_ver.AutoSize = true;
            this.label_ver.Location = new System.Drawing.Point(211, 17);
            this.label_ver.Name = "label_ver";
            this.label_ver.Size = new System.Drawing.Size(28, 13);
            this.label_ver.TabIndex = 23;
            this.label_ver.Text = "v0.1";
            this.label_ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_cc
            // 
            this.button_cc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cc.Location = new System.Drawing.Point(38, 131);
            this.button_cc.Name = "button_cc";
            this.button_cc.Size = new System.Drawing.Size(93, 42);
            this.button_cc.TabIndex = 22;
            this.button_cc.Text = "Copy to clipboard";
            this.button_cc.UseVisualStyleBackColor = true;
            this.button_cc.Click += new System.EventHandler(this.button_cc_Click);
            // 
            // label_step5
            // 
            this.label_step5.AutoSize = true;
            this.label_step5.Location = new System.Drawing.Point(13, 201);
            this.label_step5.Name = "label_step5";
            this.label_step5.Size = new System.Drawing.Size(19, 13);
            this.label_step5.TabIndex = 19;
            this.label_step5.Text = "5 -";
            // 
            // label_step4
            // 
            this.label_step4.AutoSize = true;
            this.label_step4.Location = new System.Drawing.Point(13, 146);
            this.label_step4.Name = "label_step4";
            this.label_step4.Size = new System.Drawing.Size(19, 13);
            this.label_step4.TabIndex = 18;
            this.label_step4.Text = "4 -";
            // 
            // textBox_outputCmd
            // 
            this.textBox_outputCmd.Location = new System.Drawing.Point(159, 143);
            this.textBox_outputCmd.Name = "textBox_outputCmd";
            this.textBox_outputCmd.Size = new System.Drawing.Size(479, 20);
            this.textBox_outputCmd.TabIndex = 15;
            // 
            // textBox_f2vPath
            // 
            this.textBox_f2vPath.Location = new System.Drawing.Point(159, 45);
            this.textBox_f2vPath.Name = "textBox_f2vPath";
            this.textBox_f2vPath.Size = new System.Drawing.Size(479, 20);
            this.textBox_f2vPath.TabIndex = 14;
            this.textBox_f2vPath.Click += new System.EventHandler(this.textBox_f2vPath_Click);
            // 
            // label_file2VoxPath
            // 
            this.label_file2VoxPath.AutoSize = true;
            this.label_file2VoxPath.Location = new System.Drawing.Point(13, 48);
            this.label_file2VoxPath.Name = "label_file2VoxPath";
            this.label_file2VoxPath.Size = new System.Drawing.Size(142, 13);
            this.label_file2VoxPath.TabIndex = 12;
            this.label_file2VoxPath.Text = "1 - Select FileToVox location";
            // 
            // openFileDialog_inputfile
            // 
            this.openFileDialog_inputfile.FileName = "openFileDialog_inputfile";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(193, 24);
            this.label_title.TabIndex = 21;
            this.label_title.Text = "FileToVox LazyGUI";
            // 
            // button_cmd
            // 
            this.button_cmd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cmd.Location = new System.Drawing.Point(38, 192);
            this.button_cmd.Name = "button_cmd";
            this.button_cmd.Size = new System.Drawing.Size(93, 31);
            this.button_cmd.TabIndex = 20;
            this.button_cmd.Text = "cmd.exe";
            this.button_cmd.UseVisualStyleBackColor = true;
            this.button_cmd.Click += new System.EventHandler(this.button_cmd_Click);
            // 
            // label_outputPath
            // 
            this.label_outputPath.AutoSize = true;
            this.label_outputPath.Location = new System.Drawing.Point(13, 100);
            this.label_outputPath.Name = "label_outputPath";
            this.label_outputPath.Size = new System.Drawing.Size(125, 13);
            this.label_outputPath.TabIndex = 17;
            this.label_outputPath.Text = "3 - Select output location";
            // 
            // textBox_outputFile
            // 
            this.textBox_outputFile.Location = new System.Drawing.Point(159, 97);
            this.textBox_outputFile.Name = "textBox_outputFile";
            this.textBox_outputFile.Size = new System.Drawing.Size(479, 20);
            this.textBox_outputFile.TabIndex = 13;
            this.textBox_outputFile.Click += new System.EventHandler(this.textBox_outputfile_Click);
            // 
            // textBox_inputFile
            // 
            this.textBox_inputFile.Location = new System.Drawing.Point(159, 71);
            this.textBox_inputFile.Name = "textBox_inputFile";
            this.textBox_inputFile.Size = new System.Drawing.Size(479, 20);
            this.textBox_inputFile.TabIndex = 16;
            this.textBox_inputFile.Click += new System.EventHandler(this.textBox_inputfile_Click);
            // 
            // label_inputfile
            // 
            this.label_inputfile.AutoSize = true;
            this.label_inputfile.Location = new System.Drawing.Point(13, 75);
            this.label_inputfile.Name = "label_inputfile";
            this.label_inputfile.Size = new System.Drawing.Size(94, 13);
            this.label_inputfile.TabIndex = 11;
            this.label_inputfile.Text = "2 - Select input file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 283);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_pasteAdvice);
            this.Controls.Add(this.label_ver);
            this.Controls.Add(this.button_cc);
            this.Controls.Add(this.label_step5);
            this.Controls.Add(this.label_step4);
            this.Controls.Add(this.textBox_outputCmd);
            this.Controls.Add(this.textBox_f2vPath);
            this.Controls.Add(this.label_file2VoxPath);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_cmd);
            this.Controls.Add(this.label_outputPath);
            this.Controls.Add(this.textBox_outputFile);
            this.Controls.Add(this.textBox_inputFile);
            this.Controls.Add(this.label_inputfile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_pasteAdvice;
        private System.Windows.Forms.Label label_ver;
        private System.Windows.Forms.Button button_cc;
        private System.Windows.Forms.Label label_step5;
        private System.Windows.Forms.Label label_step4;
        private System.Windows.Forms.TextBox textBox_outputCmd;
        private System.Windows.Forms.TextBox textBox_f2vPath;
        private System.Windows.Forms.Label label_file2VoxPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_outputfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog_inputfile;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_cmd;
        private System.Windows.Forms.Label label_outputPath;
        private System.Windows.Forms.TextBox textBox_outputFile;
        private System.Windows.Forms.TextBox textBox_inputFile;
        private System.Windows.Forms.Label label_inputfile;
    }
}

