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
            this.Schedulebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TweetIntervalLabel = new System.Windows.Forms.Label();
            this.TweetIntervalcomboBox = new System.Windows.Forms.ComboBox();
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
            this.ManualTextRadioButton.Location = new System.Drawing.Point(23, 28);
            this.ManualTextRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManualTextRadioButton.Name = "ManualTextRadioButton";
            this.ManualTextRadioButton.Size = new System.Drawing.Size(106, 20);
            this.ManualTextRadioButton.TabIndex = 0;
            this.ManualTextRadioButton.Text = "Text - Manual";
            this.ManualTextRadioButton.UseVisualStyleBackColor = true;
            this.ManualTextRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BuzzConfigGroupBox
            // 
            this.BuzzConfigGroupBox.Controls.Add(this.Schedulebutton);
            this.BuzzConfigGroupBox.Controls.Add(this.label2);
            this.BuzzConfigGroupBox.Controls.Add(this.TweetIntervalLabel);
            this.BuzzConfigGroupBox.Controls.Add(this.TweetIntervalcomboBox);
            this.BuzzConfigGroupBox.Controls.Add(this.NoneRadioButton);
            this.BuzzConfigGroupBox.Controls.Add(this.AutoImageRadioButton);
            this.BuzzConfigGroupBox.Controls.Add(this.AutoTextRadioButton);
            this.BuzzConfigGroupBox.Controls.Add(this.ManualTextRadioButton);
            this.BuzzConfigGroupBox.Location = new System.Drawing.Point(16, 15);
            this.BuzzConfigGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuzzConfigGroupBox.Name = "BuzzConfigGroupBox";
            this.BuzzConfigGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuzzConfigGroupBox.Size = new System.Drawing.Size(744, 198);
            this.BuzzConfigGroupBox.TabIndex = 1;
            this.BuzzConfigGroupBox.TabStop = false;
            this.BuzzConfigGroupBox.Text = "Tweet Configuration";
            this.BuzzConfigGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Schedulebutton
            // 
            this.Schedulebutton.Location = new System.Drawing.Point(616, 161);
            this.Schedulebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Schedulebutton.Name = "Schedulebutton";
            this.Schedulebutton.Size = new System.Drawing.Size(107, 28);
            this.Schedulebutton.TabIndex = 18;
            this.Schedulebutton.Text = "Schedule";
            this.Schedulebutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "minutes";
            // 
            // TweetIntervalLabel
            // 
            this.TweetIntervalLabel.AutoSize = true;
            this.TweetIntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TweetIntervalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TweetIntervalLabel.Location = new System.Drawing.Point(263, 166);
            this.TweetIntervalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TweetIntervalLabel.Name = "TweetIntervalLabel";
            this.TweetIntervalLabel.Size = new System.Drawing.Size(132, 15);
            this.TweetIntervalLabel.TabIndex = 16;
            this.TweetIntervalLabel.Text = "Auto Tweet Interval:";
            this.TweetIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TweetIntervalcomboBox
            // 
            this.TweetIntervalcomboBox.FormattingEnabled = true;
            this.TweetIntervalcomboBox.Location = new System.Drawing.Point(447, 165);
            this.TweetIntervalcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TweetIntervalcomboBox.Name = "TweetIntervalcomboBox";
            this.TweetIntervalcomboBox.Size = new System.Drawing.Size(75, 24);
            this.TweetIntervalcomboBox.TabIndex = 15;
            this.TweetIntervalcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Checked = true;
            this.NoneRadioButton.Location = new System.Drawing.Point(23, 159);
            this.NoneRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(167, 20);
            this.NoneRadioButton.TabIndex = 3;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "None - Dashboard Only";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            this.NoneRadioButton.CheckedChanged += new System.EventHandler(this.NoneRadioButton_CheckedChanged);
            // 
            // AutoImageRadioButton
            // 
            this.AutoImageRadioButton.AutoSize = true;
            this.AutoImageRadioButton.Location = new System.Drawing.Point(23, 118);
            this.AutoImageRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoImageRadioButton.Name = "AutoImageRadioButton";
            this.AutoImageRadioButton.Size = new System.Drawing.Size(149, 20);
            this.AutoImageRadioButton.TabIndex = 2;
            this.AutoImageRadioButton.Text = "Pictures - Automated";
            this.AutoImageRadioButton.UseVisualStyleBackColor = true;
            this.AutoImageRadioButton.CheckedChanged += new System.EventHandler(this.AutoImageRadioButton_CheckedChanged);
            // 
            // AutoTextRadioButton
            // 
            this.AutoTextRadioButton.AutoSize = true;
            this.AutoTextRadioButton.Location = new System.Drawing.Point(23, 71);
            this.AutoTextRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoTextRadioButton.Name = "AutoTextRadioButton";
            this.AutoTextRadioButton.Size = new System.Drawing.Size(127, 20);
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
            this.chart1.Location = new System.Drawing.Point(316, 33);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(400, 299);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // TweetTextBox
            // 
            this.TweetTextBox.Location = new System.Drawing.Point(233, 44);
            this.TweetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TweetTextBox.MaxLength = 140;
            this.TweetTextBox.Name = "TweetTextBox";
            this.TweetTextBox.Size = new System.Drawing.Size(389, 22);
            this.TweetTextBox.TabIndex = 3;
            this.TweetTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TweetButton
            // 
            this.TweetButton.Location = new System.Drawing.Point(632, 42);
            this.TweetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TweetButton.Name = "TweetButton";
            this.TweetButton.Size = new System.Drawing.Size(107, 28);
            this.TweetButton.TabIndex = 4;
            this.TweetButton.Text = "Tweet";
            this.TweetButton.UseVisualStyleBackColor = true;
            this.TweetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(233, 86);
            this.FileTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(389, 22);
            this.FileTextBox.TabIndex = 5;
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(233, 133);
            this.FolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(389, 22);
            this.FolderTextBox.TabIndex = 6;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(632, 82);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(107, 28);
            this.SelectFileButton.TabIndex = 7;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            // 
            // PicturesFolderButton
            // 
            this.PicturesFolderButton.Location = new System.Drawing.Point(632, 130);
            this.PicturesFolderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicturesFolderButton.Name = "PicturesFolderButton";
            this.PicturesFolderButton.Size = new System.Drawing.Size(107, 28);
            this.PicturesFolderButton.TabIndex = 8;
            this.PicturesFolderButton.Text = "Select Folder";
            this.PicturesFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PicturesFolderButton.UseVisualStyleBackColor = true;
            this.PicturesFolderButton.Click += new System.EventHandler(this.PicturesFolderButton_Click);
            // 
            // RetweetTextBox
            // 
            this.RetweetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetweetTextBox.Location = new System.Drawing.Point(131, 105);
            this.RetweetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RetweetTextBox.Name = "RetweetTextBox";
            this.RetweetTextBox.Size = new System.Drawing.Size(133, 44);
            this.RetweetTextBox.TabIndex = 9;
            // 
            // RetweetsLabel
            // 
            this.RetweetsLabel.AutoSize = true;
            this.RetweetsLabel.Location = new System.Drawing.Point(72, 330);
            this.RetweetsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RetweetsLabel.Name = "RetweetsLabel";
            this.RetweetsLabel.Size = new System.Drawing.Size(64, 16);
            this.RetweetsLabel.TabIndex = 10;
            this.RetweetsLabel.Text = "Retweets";
            // 
            // MentionsLabel
            // 
            this.MentionsLabel.AutoSize = true;
            this.MentionsLabel.Location = new System.Drawing.Point(75, 416);
            this.MentionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MentionsLabel.Name = "MentionsLabel";
            this.MentionsLabel.Size = new System.Drawing.Size(62, 16);
            this.MentionsLabel.TabIndex = 12;
            this.MentionsLabel.Text = "Mentions";
            // 
            // MentionsTextBox
            // 
            this.MentionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentionsTextBox.Location = new System.Drawing.Point(147, 416);
            this.MentionsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MentionsTextBox.Name = "MentionsTextBox";
            this.MentionsTextBox.Size = new System.Drawing.Size(133, 44);
            this.MentionsTextBox.TabIndex = 11;
            // 
            // FollowRequestLabel
            // 
            this.FollowRequestLabel.AutoSize = true;
            this.FollowRequestLabel.Location = new System.Drawing.Point(35, 503);
            this.FollowRequestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FollowRequestLabel.Name = "FollowRequestLabel";
            this.FollowRequestLabel.Size = new System.Drawing.Size(101, 16);
            this.FollowRequestLabel.TabIndex = 14;
            this.FollowRequestLabel.Text = "Follow Request";
            // 
            // FollowRequestTextBox
            // 
            this.FollowRequestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowRequestTextBox.Location = new System.Drawing.Point(147, 503);
            this.FollowRequestTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FollowRequestTextBox.Name = "FollowRequestTextBox";
            this.FollowRequestTextBox.Size = new System.Drawing.Size(133, 44);
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
            this.BuzzDashboardGroupBox.Location = new System.Drawing.Point(16, 225);
            this.BuzzDashboardGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuzzDashboardGroupBox.Name = "BuzzDashboardGroupBox";
            this.BuzzDashboardGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuzzDashboardGroupBox.Size = new System.Drawing.Size(744, 351);
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
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Since Last Tweet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BuzzGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 580);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox TweetIntervalcomboBox;
        private System.Windows.Forms.GroupBox BuzzDashboardGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TweetIntervalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Schedulebutton;
    }
}

