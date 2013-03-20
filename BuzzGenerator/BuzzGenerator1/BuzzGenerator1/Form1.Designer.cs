namespace BuzzGenerator1
{
    partial class BuzzGeneratorForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ManualTextRadioButton = new System.Windows.Forms.RadioButton();
            this.BuzzConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.AutoImageRadioButton = new System.Windows.Forms.RadioButton();
            this.AutoTextRadioButton = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TweetTextBox = new System.Windows.Forms.TextBox();
            this.TweetButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.PicturesFolderButton = new System.Windows.Forms.Button();
            this.RetweetTextBox = new System.Windows.Forms.TextBox();
            this.RetweetsLabel = new System.Windows.Forms.Label();
            this.MentionsLabel = new System.Windows.Forms.Label();
            this.MentionsTextBox = new System.Windows.Forms.TextBox();
            this.FollowRequestLabel = new System.Windows.Forms.Label();
            this.FollowRequestTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BuzzDashboardGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuzzConfigGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.BuzzDashboardGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManualTextRadioButton
            // 
            this.ManualTextRadioButton.AutoSize = true;
            this.ManualTextRadioButton.Location = new System.Drawing.Point(17, 23);
            this.ManualTextRadioButton.Name = "ManualTextRadioButton";
            this.ManualTextRadioButton.Size = new System.Drawing.Size(90, 17);
            this.ManualTextRadioButton.TabIndex = 0;
            this.ManualTextRadioButton.Text = "Text - Manual";
            this.ManualTextRadioButton.UseVisualStyleBackColor = true;
            this.ManualTextRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BuzzConfigGroupBox
            // 
            this.BuzzConfigGroupBox.Controls.Add(this.comboBox1);
            this.BuzzConfigGroupBox.Controls.Add(this.NoneRadioButton);
            this.BuzzConfigGroupBox.Controls.Add(this.AutoImageRadioButton);
            this.BuzzConfigGroupBox.Controls.Add(this.AutoTextRadioButton);
            this.BuzzConfigGroupBox.Controls.Add(this.ManualTextRadioButton);
            this.BuzzConfigGroupBox.Location = new System.Drawing.Point(12, 12);
            this.BuzzConfigGroupBox.Name = "BuzzConfigGroupBox";
            this.BuzzConfigGroupBox.Size = new System.Drawing.Size(548, 161);
            this.BuzzConfigGroupBox.TabIndex = 1;
            this.BuzzConfigGroupBox.TabStop = false;
            this.BuzzConfigGroupBox.Text = "Tweet Configuration";
            this.BuzzConfigGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(416, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Checked = true;
            this.NoneRadioButton.Location = new System.Drawing.Point(17, 129);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(136, 17);
            this.NoneRadioButton.TabIndex = 3;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "None - Dashboard Only";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            this.NoneRadioButton.CheckedChanged += new System.EventHandler(this.NoneRadioButton_CheckedChanged);
            // 
            // AutoImageRadioButton
            // 
            this.AutoImageRadioButton.AutoSize = true;
            this.AutoImageRadioButton.Location = new System.Drawing.Point(17, 96);
            this.AutoImageRadioButton.Name = "AutoImageRadioButton";
            this.AutoImageRadioButton.Size = new System.Drawing.Size(123, 17);
            this.AutoImageRadioButton.TabIndex = 2;
            this.AutoImageRadioButton.Text = "Pictures - Automated";
            this.AutoImageRadioButton.UseVisualStyleBackColor = true;
            this.AutoImageRadioButton.CheckedChanged += new System.EventHandler(this.AutoImageRadioButton_CheckedChanged);
            // 
            // AutoTextRadioButton
            // 
            this.AutoTextRadioButton.AutoSize = true;
            this.AutoTextRadioButton.Location = new System.Drawing.Point(17, 58);
            this.AutoTextRadioButton.Name = "AutoTextRadioButton";
            this.AutoTextRadioButton.Size = new System.Drawing.Size(106, 17);
            this.AutoTextRadioButton.TabIndex = 1;
            this.AutoTextRadioButton.Text = "Text - Automated";
            this.AutoTextRadioButton.UseVisualStyleBackColor = true;
            this.AutoTextRadioButton.CheckedChanged += new System.EventHandler(this.AutoTextRadioButton_CheckedChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(237, 27);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 243);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // TweetTextBox
            // 
            this.TweetTextBox.Location = new System.Drawing.Point(175, 36);
            this.TweetTextBox.MaxLength = 140;
            this.TweetTextBox.Name = "TweetTextBox";
            this.TweetTextBox.Size = new System.Drawing.Size(293, 20);
            this.TweetTextBox.TabIndex = 3;
            this.TweetTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TweetButton
            // 
            this.TweetButton.Location = new System.Drawing.Point(474, 34);
            this.TweetButton.Name = "TweetButton";
            this.TweetButton.Size = new System.Drawing.Size(75, 23);
            this.TweetButton.TabIndex = 4;
            this.TweetButton.Text = "Tweet";
            this.TweetButton.UseVisualStyleBackColor = true;
            this.TweetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(175, 70);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(293, 20);
            this.FileTextBox.TabIndex = 5;
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(175, 108);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(293, 20);
            this.FolderTextBox.TabIndex = 6;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(474, 67);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton.TabIndex = 7;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            // 
            // PicturesFolderButton
            // 
            this.PicturesFolderButton.Location = new System.Drawing.Point(474, 105);
            this.PicturesFolderButton.Name = "PicturesFolderButton";
            this.PicturesFolderButton.Size = new System.Drawing.Size(75, 23);
            this.PicturesFolderButton.TabIndex = 8;
            this.PicturesFolderButton.Text = "Pictures Folder";
            this.PicturesFolderButton.UseVisualStyleBackColor = true;
            // 
            // RetweetTextBox
            // 
            this.RetweetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetweetTextBox.Location = new System.Drawing.Point(98, 85);
            this.RetweetTextBox.Name = "RetweetTextBox";
            this.RetweetTextBox.Size = new System.Drawing.Size(101, 44);
            this.RetweetTextBox.TabIndex = 9;
            // 
            // RetweetsLabel
            // 
            this.RetweetsLabel.AutoSize = true;
            this.RetweetsLabel.Location = new System.Drawing.Point(54, 268);
            this.RetweetsLabel.Name = "RetweetsLabel";
            this.RetweetsLabel.Size = new System.Drawing.Size(52, 13);
            this.RetweetsLabel.TabIndex = 10;
            this.RetweetsLabel.Text = "Retweets";
            // 
            // MentionsLabel
            // 
            this.MentionsLabel.AutoSize = true;
            this.MentionsLabel.Location = new System.Drawing.Point(56, 338);
            this.MentionsLabel.Name = "MentionsLabel";
            this.MentionsLabel.Size = new System.Drawing.Size(50, 13);
            this.MentionsLabel.TabIndex = 12;
            this.MentionsLabel.Text = "Mentions";
            // 
            // MentionsTextBox
            // 
            this.MentionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentionsTextBox.Location = new System.Drawing.Point(110, 338);
            this.MentionsTextBox.Name = "MentionsTextBox";
            this.MentionsTextBox.Size = new System.Drawing.Size(101, 44);
            this.MentionsTextBox.TabIndex = 11;
            // 
            // FollowRequestLabel
            // 
            this.FollowRequestLabel.AutoSize = true;
            this.FollowRequestLabel.Location = new System.Drawing.Point(26, 409);
            this.FollowRequestLabel.Name = "FollowRequestLabel";
            this.FollowRequestLabel.Size = new System.Drawing.Size(80, 13);
            this.FollowRequestLabel.TabIndex = 14;
            this.FollowRequestLabel.Text = "Follow Request";
            // 
            // FollowRequestTextBox
            // 
            this.FollowRequestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowRequestTextBox.Location = new System.Drawing.Point(110, 409);
            this.FollowRequestTextBox.Name = "FollowRequestTextBox";
            this.FollowRequestTextBox.Size = new System.Drawing.Size(101, 44);
            this.FollowRequestTextBox.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BuzzDashboardGroupBox
            // 
            this.BuzzDashboardGroupBox.Controls.Add(this.label1);
            this.BuzzDashboardGroupBox.Controls.Add(this.chart1);
            this.BuzzDashboardGroupBox.Controls.Add(this.RetweetTextBox);
            this.BuzzDashboardGroupBox.Location = new System.Drawing.Point(12, 183);
            this.BuzzDashboardGroupBox.Name = "BuzzDashboardGroupBox";
            this.BuzzDashboardGroupBox.Size = new System.Drawing.Size(548, 285);
            this.BuzzDashboardGroupBox.TabIndex = 16;
            this.BuzzDashboardGroupBox.TabStop = false;
            this.BuzzDashboardGroupBox.Text = "Insights Dashboard";
            this.BuzzDashboardGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Since Last Tweet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BuzzGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 471);
            this.Controls.Add(this.FollowRequestLabel);
            this.Controls.Add(this.FollowRequestTextBox);
            this.Controls.Add(this.MentionsLabel);
            this.Controls.Add(this.MentionsTextBox);
            this.Controls.Add(this.RetweetsLabel);
            this.Controls.Add(this.PicturesFolderButton);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.TweetButton);
            this.Controls.Add(this.TweetTextBox);
            this.Controls.Add(this.BuzzConfigGroupBox);
            this.Controls.Add(this.BuzzDashboardGroupBox);
            this.MaximizeBox = false;
            this.Name = "BuzzGeneratorForm";
            this.Text = "TweetInsights";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BuzzConfigGroupBox.ResumeLayout(false);
            this.BuzzConfigGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.BuzzDashboardGroupBox.ResumeLayout(false);
            this.BuzzDashboardGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ManualTextRadioButton;
        private System.Windows.Forms.GroupBox BuzzConfigGroupBox;
        private System.Windows.Forms.RadioButton NoneRadioButton;
        private System.Windows.Forms.RadioButton AutoImageRadioButton;
        private System.Windows.Forms.RadioButton AutoTextRadioButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox TweetTextBox;
        private System.Windows.Forms.Button TweetButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button PicturesFolderButton;
        private System.Windows.Forms.TextBox RetweetTextBox;
        private System.Windows.Forms.Label RetweetsLabel;
        private System.Windows.Forms.Label MentionsLabel;
        private System.Windows.Forms.TextBox MentionsTextBox;
        private System.Windows.Forms.Label FollowRequestLabel;
        private System.Windows.Forms.TextBox FollowRequestTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox BuzzDashboardGroupBox;
        private System.Windows.Forms.Label label1;
    }
}

