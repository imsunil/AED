using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.Windows.Forms;

namespace BuzzGenerator1
{
    class MyTwitter
    {
        private int initialRetweets = 0;
        private int initialTotalRetweets = 0;
        private int initialMentions = 0;
        private int initialFollowRequests = 0;
        private long lastTweetID = 313821879632793601;

        public int Retweets = 0;
        public int Mentions = 0;
        public int FollowRequests = 0;

        private string consumerKey = "bWDpCLO2mIByqMYoaRh2Cg";
        private string consumerSecret = "X4veUKVWhB09wipWhVpaVhXvLDHqzIjnOLOGXxiY8Y";
        private string accessToken = "25963011-QuJkeaEcXqB92bhMxoIJHKBLFHP1rPZysu6K68IqZ";
        private string accessTokenSecret = "pY0TXRW8aIUSDfSUpJAzsQ2s2Oay2A0HBdiaK1Z8";

        public TwitterService service;
        
        
        public MyTwitter()
        {
            service = new TwitterService(consumerKey, consumerSecret);
            service.AuthenticateWith(accessToken, accessTokenSecret);
            //var service = new TwitterService("tedRo766zL7mr7TKZkOugA", "WREOp5SZ71EtLCt3T4RboUv1IrkUpPkCpcBxkAGk8");
            //service.AuthenticateWith("21985278-dud1wSertHCQYTUK5ta5AA0ciqWB31ZsT8Dt8DJg", "yPDp2TTOOhQj6XDxX7P5TxmNtHZcQ6sJumth8DVzRk");
            InitializeMetrics();

        }

        private void InitializeMetrics()
        {
            //lastTweetID = GetLastTweetID();
            GetRetweetsSinceLastTweet();
            GetMentionsSinceLastTweet();

        }

        private void GetMentionsSinceLastTweet()
        {
            ListTweetsMentioningMeOptions myMentionOptions = new ListTweetsMentioningMeOptions();
            //myRetweetOptions.SinceId = lastTweetID;
            //myRetweetOptions.Count = 100;
            myMentionOptions.Count = 200;


            var tweets = service.ListTweetsMentioningMe(myMentionOptions);


            foreach (var tweet in tweets)
            {
                initialMentions = initialMentions + 1;

            }
            MessageBox.Show(initialMentions.ToString());
            
        }

        private void GetRetweetsSinceLastTweet()
        {

            ListRetweetsOfMyTweetsOptions myRetweetOptions = new ListRetweetsOfMyTweetsOptions();
            //myRetweetOptions.SinceId = lastTweetID;
            myRetweetOptions.Count = 100;

            var tweets = service.ListRetweetsOfMyTweets(myRetweetOptions);


            foreach (var tweet in tweets)
            {
                initialRetweets = initialRetweets + 1;
                initialTotalRetweets = initialTotalRetweets + tweet.RetweetCount;
            }
            //MessageBox.Show( initialRetweets.ToString());
            //MessageBox.Show( initialTotalRetweets.ToString());
            
        }

        private long GetLastTweetID()
        {
            ListTweetsOnUserTimelineOptions userTimelineOptions = new ListTweetsOnUserTimelineOptions();
            userTimelineOptions.Count = 1;
            var tweets = service.ListTweetsOnUserTimeline(userTimelineOptions); 
            long lastTweetId=0;
            foreach (var tweet in tweets)
            {
                lastTweetId = tweet.Id;
            }
            //MessageBox.Show(lastTweetId.ToString());
            return lastTweetId;
        }

        //service.AuthenticateWith(accessToken, accessTokenSecret);

        public void SetInitialCounters()
        {
            FollowRequests = 0;
            Mentions = 0;
            Retweets = 0;
        }

        public void SendTweet(String status)
        { 
        var tweetoptions = new SendTweetOptions();
        tweetoptions.Status = status;

        MessageBox.Show(status);

        service.SendTweet(tweetoptions);
        //service.SendTweet(tweetoptions);
        
        }

    }
}
