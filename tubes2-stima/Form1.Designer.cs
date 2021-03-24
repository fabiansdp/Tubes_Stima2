namespace tubes2_stima
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.visualisasiGraf = new System.Windows.Forms.Panel();
            this.judulAplikasi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonBFS = new System.Windows.Forms.RadioButton();
            this.radioButtonDFS = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.chooseAccountDropDown = new System.Windows.Forms.ComboBox();
            this.exploreFriendDropDown = new System.Windows.Forms.ComboBox();
            this.friendRecommendLabel = new System.Windows.Forms.Label();
            this.fileBrowserButton = new System.Windows.Forms.Button();
            this.namaFileUploaded = new System.Windows.Forms.Label();
            this.recommend = new System.Windows.Forms.Label();
            this.titleKoneksi = new System.Windows.Forms.Label();
            this.jalurKoneksi = new System.Windows.Forms.Label();
            this.degreeConnection = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            flowLayoutPanel2.Controls.Add(this.visualisasiGraf);
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(509, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(537, 573);
            flowLayoutPanel2.TabIndex = 23;
            // 
            // visualisasiGraf
            // 
            this.visualisasiGraf.BackColor = System.Drawing.Color.Transparent;
            this.visualisasiGraf.Location = new System.Drawing.Point(3, 5);
            this.visualisasiGraf.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.visualisasiGraf.Name = "visualisasiGraf";
            this.visualisasiGraf.Size = new System.Drawing.Size(501, 699);
            this.visualisasiGraf.TabIndex = 18;
            this.visualisasiGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.visualisasiGraf_Paint);
            // 
            // judulAplikasi
            // 
            this.judulAplikasi.AutoSize = true;
            this.judulAplikasi.BackColor = System.Drawing.Color.Transparent;
            this.judulAplikasi.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulAplikasi.ForeColor = System.Drawing.Color.White;
            this.judulAplikasi.Location = new System.Drawing.Point(11, 12);
            this.judulAplikasi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.judulAplikasi.Name = "judulAplikasi";
            this.judulAplikasi.Size = new System.Drawing.Size(475, 70);
            this.judulAplikasi.TabIndex = 3;
            this.judulAplikasi.Text = "People You May Know";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Graph File   :";
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.BackColor = System.Drawing.Color.Transparent;
            this.filePath.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.ForeColor = System.Drawing.Color.White;
            this.filePath.Location = new System.Drawing.Point(235, 90);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(0, 30);
            this.filePath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algorithm     :";
            // 
            // radioButtonBFS
            // 
            this.radioButtonBFS.AutoSize = true;
            this.radioButtonBFS.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonBFS.ForeColor = System.Drawing.Color.White;
            this.radioButtonBFS.Location = new System.Drawing.Point(151, 135);
            this.radioButtonBFS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radioButtonBFS.Name = "radioButtonBFS";
            this.radioButtonBFS.Size = new System.Drawing.Size(57, 29);
            this.radioButtonBFS.TabIndex = 7;
            this.radioButtonBFS.TabStop = true;
            this.radioButtonBFS.Text = "BFS";
            this.radioButtonBFS.UseVisualStyleBackColor = false;
            this.radioButtonBFS.CheckedChanged += new System.EventHandler(this.radioButtonBFS_CheckedChanged);
            // 
            // radioButtonDFS
            // 
            this.radioButtonDFS.AutoSize = true;
            this.radioButtonDFS.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDFS.ForeColor = System.Drawing.Color.White;
            this.radioButtonDFS.Location = new System.Drawing.Point(222, 135);
            this.radioButtonDFS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radioButtonDFS.Name = "radioButtonDFS";
            this.radioButtonDFS.Size = new System.Drawing.Size(58, 29);
            this.radioButtonDFS.TabIndex = 8;
            this.radioButtonDFS.TabStop = true;
            this.radioButtonDFS.Text = "DFS";
            this.radioButtonDFS.UseVisualStyleBackColor = false;
            this.radioButtonDFS.CheckedChanged += new System.EventHandler(this.radioButtonDFS_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Explore Friend With";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.Location = new System.Drawing.Point(24, 283);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 34);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // chooseAccountDropDown
            // 
            this.chooseAccountDropDown.FormattingEnabled = true;
            this.chooseAccountDropDown.Location = new System.Drawing.Point(195, 194);
            this.chooseAccountDropDown.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chooseAccountDropDown.Name = "chooseAccountDropDown";
            this.chooseAccountDropDown.Size = new System.Drawing.Size(121, 31);
            this.chooseAccountDropDown.TabIndex = 12;
            this.chooseAccountDropDown.SelectedIndexChanged += new System.EventHandler(this.chooseAccountDropDown_SelectedIndexChanged);
            // 
            // exploreFriendDropDown
            // 
            this.exploreFriendDropDown.FormattingEnabled = true;
            this.exploreFriendDropDown.Location = new System.Drawing.Point(195, 236);
            this.exploreFriendDropDown.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.exploreFriendDropDown.Name = "exploreFriendDropDown";
            this.exploreFriendDropDown.Size = new System.Drawing.Size(121, 31);
            this.exploreFriendDropDown.TabIndex = 13;
            this.exploreFriendDropDown.SelectedIndexChanged += new System.EventHandler(this.exploreFriendDropDown_SelectedIndexChanged);
            // 
            // friendRecommendLabel
            // 
            this.friendRecommendLabel.AutoSize = true;
            this.friendRecommendLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendRecommendLabel.ForeColor = System.Drawing.Color.White;
            this.friendRecommendLabel.Location = new System.Drawing.Point(3, 96);
            this.friendRecommendLabel.Name = "friendRecommendLabel";
            this.friendRecommendLabel.Size = new System.Drawing.Size(297, 36);
            this.friendRecommendLabel.TabIndex = 14;
            this.friendRecommendLabel.Text = "Friends Recomendation for ";
            // 
            // fileBrowserButton
            // 
            this.fileBrowserButton.Location = new System.Drawing.Point(151, 87);
            this.fileBrowserButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fileBrowserButton.Name = "fileBrowserButton";
            this.fileBrowserButton.Size = new System.Drawing.Size(75, 34);
            this.fileBrowserButton.TabIndex = 15;
            this.fileBrowserButton.Text = "Browse";
            this.fileBrowserButton.UseVisualStyleBackColor = true;
            this.fileBrowserButton.Click += new System.EventHandler(this.fileBrowserButton_Click);
            // 
            // namaFileUploaded
            // 
            this.namaFileUploaded.AutoSize = true;
            this.namaFileUploaded.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaFileUploaded.ForeColor = System.Drawing.Color.White;
            this.namaFileUploaded.Location = new System.Drawing.Point(241, 89);
            this.namaFileUploaded.Name = "namaFileUploaded";
            this.namaFileUploaded.Size = new System.Drawing.Size(0, 30);
            this.namaFileUploaded.TabIndex = 16;
            // 
            // recommend
            // 
            this.recommend.AutoSize = true;
            this.recommend.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommend.ForeColor = System.Drawing.Color.White;
            this.recommend.Location = new System.Drawing.Point(3, 132);
            this.recommend.Name = "recommend";
            this.recommend.Size = new System.Drawing.Size(0, 30);
            this.recommend.TabIndex = 17;
            // 
            // titleKoneksi
            // 
            this.titleKoneksi.AutoSize = true;
            this.titleKoneksi.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.titleKoneksi.ForeColor = System.Drawing.Color.White;
            this.titleKoneksi.Location = new System.Drawing.Point(3, 0);
            this.titleKoneksi.Name = "titleKoneksi";
            this.titleKoneksi.Size = new System.Drawing.Size(152, 36);
            this.titleKoneksi.TabIndex = 19;
            this.titleKoneksi.Text = "Jalur Koneksi";
            // 
            // jalurKoneksi
            // 
            this.jalurKoneksi.AutoSize = true;
            this.jalurKoneksi.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jalurKoneksi.ForeColor = System.Drawing.Color.White;
            this.jalurKoneksi.Location = new System.Drawing.Point(3, 66);
            this.jalurKoneksi.Name = "jalurKoneksi";
            this.jalurKoneksi.Size = new System.Drawing.Size(0, 30);
            this.jalurKoneksi.TabIndex = 20;
            // 
            // degreeConnection
            // 
            this.degreeConnection.AutoSize = true;
            this.degreeConnection.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeConnection.ForeColor = System.Drawing.Color.White;
            this.degreeConnection.Location = new System.Drawing.Point(3, 36);
            this.degreeConnection.Name = "degreeConnection";
            this.degreeConnection.Size = new System.Drawing.Size(0, 30);
            this.degreeConnection.TabIndex = 21;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.titleKoneksi);
            this.flowLayoutPanel1.Controls.Add(this.degreeConnection);
            this.flowLayoutPanel1.Controls.Add(this.jalurKoneksi);
            this.flowLayoutPanel1.Controls.Add(this.friendRecommendLabel);
            this.flowLayoutPanel1.Controls.Add(this.recommend);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 335);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 241);
            this.flowLayoutPanel1.TabIndex = 22;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1054, 579);
            this.Controls.Add(flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.namaFileUploaded);
            this.Controls.Add(this.fileBrowserButton);
            this.Controls.Add(this.exploreFriendDropDown);
            this.Controls.Add(this.chooseAccountDropDown);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonDFS);
            this.Controls.Add(this.radioButtonBFS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.judulAplikasi);
            this.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Text = "Tubes Stima 2";
            flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label judulAplikasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonBFS;
        private System.Windows.Forms.RadioButton radioButtonDFS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox chooseAccountDropDown;
        private System.Windows.Forms.ComboBox exploreFriendDropDown;
        private System.Windows.Forms.Label friendRecommendLabel;
        private System.Windows.Forms.Button fileBrowserButton;
        private System.Windows.Forms.Label namaFileUploaded;
        private System.Windows.Forms.Label recommend;
        private System.Windows.Forms.Panel visualisasiGraf;
        private System.Windows.Forms.Label titleKoneksi;
        private System.Windows.Forms.Label jalurKoneksi;
        private System.Windows.Forms.Label degreeConnection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

