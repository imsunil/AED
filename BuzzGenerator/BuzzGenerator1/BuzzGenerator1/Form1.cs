using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzGenerator1
{
    public partial class BuzzGeneratorForm : Form
    {
        private MyTwitter mytwitter = new MyTwitter();
        Timer DashboardRefreshTimer = new Timer();

        
        
        public BuzzGeneratorForm()
        {
            InitializeComponent();
            InitializeDashboardTimer();
        }

        private void InitializeDashboardTimer()
        {
            DashboardRefreshTimer = new Timer();
            DashboardRefreshTimer.Interval = 30000;
            DashboardRefreshTimer.Tick += new EventHandler(DashboardRefreshTimer_Tick);
            DashboardRefreshTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableAll();
            InitializeCounters();
            Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TweetTextBox.Text == "")
                MessageBox.Show("Please enter some text to tweet");
            else
            {
                mytwitter.SendTweet(TweetTextBox.Text);
                TweetTextBox.Text = "";
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DisableAll();
            Enable(TweetTextBox, TweetButton);
            Display();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void NoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Disable all configuration checkboxes and buttons
            //Determine last retweet and mention and count of pending requests
            DisableAll();
            Display();

            


        }

        private void DashboardRefreshTimer_Tick(object sender, EventArgs e)
        {
            if (sender == DashboardRefreshTimer)
            {
               // label1.Text = DateTime.Now.ToLongTimeString();
                mytwitter.UpdateCounters();
                Display();
            }

        }

        private void AutoImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Disable all configuration checkboxes and buttons
            //Clear and Enable Folder textbox and button

        }

        private void AutoTextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Disable all configuration checkboxes and buttons
            //Clear and Enable File textbox and button
        }

        private void DisableAll()
        {
            TweetTextBox.Text = "";
            TweetTextBox.ReadOnly = true;
            TweetButton.Enabled = false;
            FileTextBox.Text ="";
            FileTextBox.ReadOnly = true;
            SelectFileButton.Enabled = false;
            FolderTextBox.Text = "";
            FolderTextBox.ReadOnly = true;
            PicturesFolderButton.Enabled = false;       
        }

        private void InitializeCounters()
        {
            mytwitter.InitializeMetrics();
        }

        private void Enable(TextBox ATextBox,Button AButton)
        {
            ATextBox.ReadOnly = false;
            AButton.Enabled = true;
        }

        private void Display()
        {
            RetweetTextBox.Text = mytwitter.Retweets.ToString();
            MentionsTextBox.Text = mytwitter.Mentions.ToString();
            FollowRequestTextBox.Text = mytwitter.FollowRequests.ToString();
        }
    }
}
