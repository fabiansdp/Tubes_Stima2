﻿namespace tubes2_stima
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
            this.visualisasiGraf = new System.Windows.Forms.Panel();
            this.titleKoneksi = new System.Windows.Forms.Label();
            this.jalurKoneksi = new System.Windows.Forms.Label();
            this.degreeConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // judulAplikasi
            // 
            this.judulAplikasi.AutoSize = true;
            this.judulAplikasi.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulAplikasi.Location = new System.Drawing.Point(11, 9);
            this.judulAplikasi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.judulAplikasi.Name = "judulAplikasi";
            this.judulAplikasi.Size = new System.Drawing.Size(475, 70);
            this.judulAplikasi.TabIndex = 3;
            this.judulAplikasi.Text = "People You May Know";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Graph File   :";
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Location = new System.Drawing.Point(234, 83);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(0, 17);
            this.filePath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algorithm     :";
            // 
            // radioButtonBFS
            // 
            this.radioButtonBFS.AutoSize = true;
            this.radioButtonBFS.Location = new System.Drawing.Point(153, 113);
            this.radioButtonBFS.Name = "radioButtonBFS";
            this.radioButtonBFS.Size = new System.Drawing.Size(55, 21);
            this.radioButtonBFS.TabIndex = 7;
            this.radioButtonBFS.TabStop = true;
            this.radioButtonBFS.Text = "BFS";
            this.radioButtonBFS.UseVisualStyleBackColor = true;
            this.radioButtonBFS.CheckedChanged += new System.EventHandler(this.radioButtonBFS_CheckedChanged);
            // 
            // radioButtonDFS
            // 
            this.radioButtonDFS.AutoSize = true;
            this.radioButtonDFS.Location = new System.Drawing.Point(224, 113);
            this.radioButtonDFS.Name = "radioButtonDFS";
            this.radioButtonDFS.Size = new System.Drawing.Size(56, 21);
            this.radioButtonDFS.TabIndex = 8;
            this.radioButtonDFS.TabStop = true;
            this.radioButtonDFS.Text = "DFS";
            this.radioButtonDFS.UseVisualStyleBackColor = true;
            this.radioButtonDFS.CheckedChanged += new System.EventHandler(this.radioButtonDFS_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Explore Friend With";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(26, 217);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // chooseAccountDropDown
            // 
            this.chooseAccountDropDown.FormattingEnabled = true;
            this.chooseAccountDropDown.Location = new System.Drawing.Point(156, 152);
            this.chooseAccountDropDown.Name = "chooseAccountDropDown";
            this.chooseAccountDropDown.Size = new System.Drawing.Size(121, 24);
            this.chooseAccountDropDown.TabIndex = 12;
            this.chooseAccountDropDown.SelectedIndexChanged += new System.EventHandler(this.chooseAccountDropDown_SelectedIndexChanged);
            // 
            // exploreFriendDropDown
            // 
            this.exploreFriendDropDown.FormattingEnabled = true;
            this.exploreFriendDropDown.Location = new System.Drawing.Point(156, 181);
            this.exploreFriendDropDown.Name = "exploreFriendDropDown";
            this.exploreFriendDropDown.Size = new System.Drawing.Size(121, 24);
            this.exploreFriendDropDown.TabIndex = 13;
            this.exploreFriendDropDown.SelectedIndexChanged += new System.EventHandler(this.exploreFriendDropDown_SelectedIndexChanged);
            // 
            // friendRecommendLabel
            // 
            this.friendRecommendLabel.AutoSize = true;
            this.friendRecommendLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendRecommendLabel.Location = new System.Drawing.Point(20, 362);
            this.friendRecommendLabel.Name = "friendRecommendLabel";
            this.friendRecommendLabel.Size = new System.Drawing.Size(297, 36);
            this.friendRecommendLabel.TabIndex = 14;
            this.friendRecommendLabel.Text = "Friends Recomendation for ";
            // 
            // fileBrowserButton
            // 
            this.fileBrowserButton.Location = new System.Drawing.Point(153, 80);
            this.fileBrowserButton.Name = "fileBrowserButton";
            this.fileBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.fileBrowserButton.TabIndex = 15;
            this.fileBrowserButton.Text = "Browse";
            this.fileBrowserButton.UseVisualStyleBackColor = true;
            this.fileBrowserButton.Click += new System.EventHandler(this.fileBrowserButton_Click);
            // 
            // namaFileUploaded
            // 
            this.namaFileUploaded.AutoSize = true;
            this.namaFileUploaded.Location = new System.Drawing.Point(237, 85);
            this.namaFileUploaded.Name = "namaFileUploaded";
            this.namaFileUploaded.Size = new System.Drawing.Size(0, 17);
            this.namaFileUploaded.TabIndex = 16;
            // 
            // recommend
            // 
            this.recommend.AutoSize = true;
            this.recommend.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommend.Location = new System.Drawing.Point(22, 398);
            this.recommend.Name = "recommend";
            this.recommend.Size = new System.Drawing.Size(0, 20);
            this.recommend.TabIndex = 17;
            // 
            // visualisasiGraf
            // 
            this.visualisasiGraf.Location = new System.Drawing.Point(650, 9);
            this.visualisasiGraf.Name = "visualisasiGraf";
            this.visualisasiGraf.Size = new System.Drawing.Size(686, 755);
            this.visualisasiGraf.TabIndex = 18;
            // 
            // titleKoneksi
            // 
            this.titleKoneksi.AutoSize = true;
            this.titleKoneksi.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.titleKoneksi.Location = new System.Drawing.Point(20, 260);
            this.titleKoneksi.Name = "titleKoneksi";
            this.titleKoneksi.Size = new System.Drawing.Size(152, 36);
            this.titleKoneksi.TabIndex = 19;
            this.titleKoneksi.Text = "Jalur Koneksi";
            // 
            // jalurKoneksi
            // 
            this.jalurKoneksi.AutoSize = true;
            this.jalurKoneksi.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.jalurKoneksi.Location = new System.Drawing.Point(22, 324);
            this.jalurKoneksi.Name = "jalurKoneksi";
            this.jalurKoneksi.Size = new System.Drawing.Size(0, 20);
            this.jalurKoneksi.TabIndex = 20;
            // 
            // degreeConnection
            // 
            this.degreeConnection.AutoSize = true;
            this.degreeConnection.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeConnection.Location = new System.Drawing.Point(23, 296);
            this.degreeConnection.Name = "degreeConnection";
            this.degreeConnection.Size = new System.Drawing.Size(0, 20);
            this.degreeConnection.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 779);
            this.Controls.Add(this.degreeConnection);
            this.Controls.Add(this.jalurKoneksi);
            this.Controls.Add(this.titleKoneksi);
            this.Controls.Add(this.visualisasiGraf);
            this.Controls.Add(this.recommend);
            this.Controls.Add(this.namaFileUploaded);
            this.Controls.Add(this.fileBrowserButton);
            this.Controls.Add(this.friendRecommendLabel);
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
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Text = "Tubes Stima 2";
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
    }
}

