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
        private MyTwitter mytwitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
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
            InitializeTweetIntervalCombobox();
            Display();
        }

        private void InitializeTweetIntervalCombobox()
        {
          
                var TweetIntervalDataTable = new DataTable();
                TweetIntervalDataTable.TableName = "Interval";
                TweetIntervalDataTable.Columns.Add("Minutes");
                TweetIntervalDataTable.Columns.Add("Miliseconds");
                for (int i = 1; i <= 15; i++)
                {
                    TweetIntervalDataTable.Rows.Add(i.ToString(), (i * 60000).ToString());
                }
                TweetIntervalcomboBox.DataSource=TweetIntervalDataTable;
                TweetIntervalcomboBox.DisplayMember="Minutes";
                TweetIntervalcomboBox.ValueMember="Miliseconds";
            
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
               // mytwitter.GetRetweetsSinceLastTweet();
                Display();
            }

        }

        private void AutoImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Disable all configuration checkboxes and buttons
            //Clear and Enable Folder textbox and button
            DisableAll();
            Enable(FolderTextBox, PicturesFolderButton);
            TweetIntervalcomboBox.Enabled = true;
            //Display();
            //Enable(TweetIntervalcomboBox, Schedulebutton);
            Schedulebutton.Enabled = true;

        }

        private void AutoTextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Disable all configuration checkboxes and buttons
            //Clear and Enable File textbox and button
            DisableAll();
            Enable(FileTextBox, SelectFileButton);
            TweetIntervalcomboBox.Enabled = true; 
            Schedulebutton.Enabled = true;
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
            TweetIntervalcomboBox.Enabled = false;
            Schedulebutton.Enabled = false;

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
            if (mytwitter.Retweets == null)
            {
                MessageBox.Show("null retweet object");
            }
            RetweetTextBox.Text = mytwitter.Retweets.ToString();
            MentionsTextBox.Text = mytwitter.Mentions.ToString();
            FollowRequestTextBox.Text = mytwitter.FollowRequests.ToString();

            //RetweetTextBox.Text = "0";
            //MentionsTextBox.Text = "0";
            //FollowRequestTextBox.Text = "0";
        }


        private void PicturesFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FolderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void Schedulebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
    }
}
