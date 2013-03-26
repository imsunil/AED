using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.Windows.Forms;
using Xunit;

namespace BuzzGenerator1
{
    public class MyTwitterTests
    {
        [Fact]
        public void GetFollowRequestIsIntTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            Assert.IsType(typeof(int), twitter.GetFollowRequests());
        }

        [Fact]
        public void GetFollowRequestIsNotZeroTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            Assert.True(twitter.GetFollowRequests() > 0);
        }

        [Fact]
        public void GetFollowRequestIsZeroTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKeyMock, MyTwitter.consumerSecretMock, MyTwitter.accessTokenMock, MyTwitter.accessTokenSecretMock);
            Assert.True(twitter.GetFollowRequests() == 0);
        }

        [Fact]
        public void GetMentionsSinceLastTweetIsIntTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            Assert.IsType(typeof(int), twitter.GetMentionsSinceLastTweet());
        }

        [Fact]
        public void GetMentionsSinceLastTweetIsNotZeroTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            Assert.True(twitter.GetMentionsSinceLastTweet() > 0);
        }

        [Fact]
        public void GetMentionsSinceLastTweetIsZeroTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKeyMock, MyTwitter.consumerSecretMock, MyTwitter.accessTokenMock, MyTwitter.accessTokenSecretMock);
            Assert.True(twitter.GetMentionsSinceLastTweet() == 0);
        }

        [Fact]
        public void GetRetweetsSinceLastTweetNotZeroTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            Assert.True(twitter.GetRetweetsSinceLastTweet() > 0);
        }

        [Fact]
        public void GetRetweetsSinceLastTweetIsIntTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            Assert.IsType(typeof(int), twitter.GetRetweetsSinceLastTweet());
        }

        [Fact]
        public void GetRetweetsSinceLastTweetZeroTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKeyMock, MyTwitter.consumerSecretMock, MyTwitter.accessTokenMock, MyTwitter.accessTokenSecretMock);
            Assert.True(twitter.GetRetweetsSinceLastTweet() == 0);
        }

        [Fact]
        public void SetInitialCounterTest()
        {
            MyTwitter twitter = new MyTwitter();
            twitter.SetInitialCounters();
            Assert.True(twitter.Retweets == 0);
            Assert.True(twitter.Mentions == 0);
            Assert.True(twitter.FollowRequests == 0);
        }

        [Fact]
        public void GetInitialCounterWithStatsTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            twitter.InitializeMetrics();
            Assert.True(twitter.Retweets > 0);
            Assert.True(twitter.Mentions > 0);
            Assert.True(twitter.FollowRequests > 0);
        }

        [Fact]
        public void GetInitialCounterWithNoStatsTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKeyMock, MyTwitter.consumerSecretMock, MyTwitter.accessTokenMock, MyTwitter.accessTokenSecretMock);
            twitter.InitializeMetrics();
            Assert.True(twitter.Retweets == 0);
            Assert.True(twitter.Mentions == 0);
            Assert.True(twitter.FollowRequests == 0);
        }

        [Fact]
        public void UpdateCountersWithStatsTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            twitter.UpdateCounters();
            Assert.True(twitter.Retweets > 0);
            Assert.True(twitter.Mentions > 0);
            Assert.True(twitter.FollowRequests > 0);
        }

        [Fact]
        public void UpdateCountersWithNoStatsTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKeyMock, MyTwitter.consumerSecretMock, MyTwitter.accessTokenMock, MyTwitter.accessTokenSecretMock);
            twitter.UpdateCounters();
            Assert.True(twitter.Retweets == 0);
            Assert.True(twitter.Mentions == 0);
            Assert.True(twitter.FollowRequests == 0);
        }

        [Fact]
        public void SendTweetUsingNullCredentialsTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKeyNull, MyTwitter.consumerSecretNull, MyTwitter.accessTokenNull, MyTwitter.accessTokenSecretNull);
            Assert.Throws<InvalidOperationException>(() => twitter.SendTweet(string.Empty));
        }

        [Fact]
        //Expect no exceptions with valid credentials
        public void SendTweetUsingValidCredentialsTest()
        {
            MyTwitter twitter = new MyTwitter(MyTwitter.consumerKey2, MyTwitter.consumerSecret2, MyTwitter.accessToken2, MyTwitter.accessTokenSecret2);
            twitter.SendTweet(string.Empty);
        }

    }
    class MyTwitter
    {
        private int? initialRetweets = 0;
        private int initialTotalRetweets = 0;
        private int initialMentions = 0;
        private int initialFollowRequests = 0;
        //private long lastTweetID = 313821879632793601; SA account
        private long lastTweetID = 314609839286394880;
        
        public int? Retweets = 0;
        public int Mentions = 0;
        public int FollowRequests = 0;

        internal static string consumerKey = "bWDpCLO2mIByqMYoaRh2Cg";
        internal static string consumerSecret = "X4veUKVWhB09wipWhVpaVhXvLDHqzIjnOLOGXxiY8Y";
        internal static string accessToken = "25963011-QuJkeaEcXqB92bhMxoIJHKBLFHP1rPZysu6K68IqZ";
        internal static string accessTokenSecret = "pY0TXRW8aIUSDfSUpJAzsQ2s2Oay2A0HBdiaK1Z8";

        //Sunils account
        internal static string consumerKey2 = "tedRo766zL7mr7TKZkOugA";
        internal static string consumerSecret2 = "WREOp5SZ71EtLCt3T4RboUv1IrkUpPkCpcBxkAGk8";
        internal static string accessToken2 = "21985278-dud1wSertHCQYTUK5ta5AA0ciqWB31ZsT8Dt8DJg";
        internal static string accessTokenSecret2 = "yPDp2TTOOhQj6XDxX7P5TxmNtHZcQ6sJumth8DVzRk";

        //Mock account
        //1302041244-nvXXKtE0cYdJbgy0hro4MbgvH0HONsP8FN7S13f
        internal static string consumerKeyMock = "n10M4AyVX9iejaV2sJgn6w";
        internal static string consumerSecretMock = "T21rAo6uR6FKPW3dt5OB5xlsEIIgzqxQFqp7gTbWw";
        internal static string accessTokenMock = "1302041244-nvXXKtE0cYdJbgy0hro4MbgvH0HONsP8FN7S13f";
        internal static string accessTokenSecretMock = "MOrY5h1r0P16wNXw5WVGQ9D8F3DhHYfLmDLhtSLAw";

        //Null account
        internal static string consumerKeyNull = string.Empty;
        internal static string consumerSecretNull = string.Empty;
        internal static string accessTokenNull = string.Empty;
        internal static string accessTokenSecretNull = string.Empty;

        public TwitterService service;


        public MyTwitter()
        {

        }
        public MyTwitter(string key, string secret, string token, string tokenSecret)
        {
            service = new TwitterService(key, secret);
            service.AuthenticateWith(token, tokenSecret);
            //var service = new TwitterService("tedRo766zL7mr7TKZkOugA", "WREOp5SZ71EtLCt3T4RboUv1IrkUpPkCpcBxkAGk8");
            //service.AuthenticateWith("21985278-dud1wSertHCQYTUK5ta5AA0ciqWB31ZsT8Dt8DJg", "yPDp2TTOOhQj6XDxX7P5TxmNtHZcQ6sJumth8DVzRk");
       
        }

        public void InitializeMetrics()
        {
            //lastTweetID = GetLastTweetID(); Disabled to avoid dynamically setting it
            Retweets=initialRetweets=GetRetweetsSinceLastTweet();
            Mentions=initialMentions = GetMentionsSinceLastTweet();
            FollowRequests = initialFollowRequests = GetFollowRequests();
        }



        internal int GetFollowRequests()
        {
            int followers=0;
            var followerLists = service.GetIncomingFriendRequests(new GetIncomingFriendRequestsOptions());

            if (followerLists == null)
                return followers;
            
            
            foreach (var follower in followerLists)
            {
                followers = followers + 1;
            }
            return  followers;
        }

        internal int GetMentionsSinceLastTweet()
        {
            ListTweetsMentioningMeOptions myMentionOptions = new ListTweetsMentioningMeOptions();
            myMentionOptions.Count = 200;
            myMentionOptions.SinceId = lastTweetID;
            int mentions = 0;
            var tweets = service.ListTweetsMentioningMe(myMentionOptions);

            if (tweets == null)
                return mentions;

            foreach (var tweet in tweets)
            {
                mentions = mentions + 1;
            }
            return mentions;
        }

        internal int? GetRetweetsSinceLastTweet()
        {

            ListRetweetsOfMyTweetsOptions myRetweetOptions = new ListRetweetsOfMyTweetsOptions();
            myRetweetOptions.SinceId = lastTweetID;
            myRetweetOptions.Count = 100;
           // MessageBox.Show(myRetweetOptions.SinceId.ToString());
            var tweets = service.ListRetweetsOfMyTweets(myRetweetOptions);
            int retweets = 0;

            if (tweets == null)
              // MessageBox.Show("null retweet object");
                return retweets;

            foreach (var tweet in tweets)
            {
                retweets = retweets + 1;
                //MessageBox.Show(retweets.ToString());
                initialTotalRetweets = initialTotalRetweets + tweet.RetweetCount;
            }
            return retweets;
        }

        private long GetLastTweetID()
        {
            //ListTweetsOnUserTimelineOptions userTimelineOptions = new ListTweetsOnUserTimelineOptions();
            //userTimelineOptions.Count = 1;
            //var tweets = service.ListTweetsOnUserTimeline(userTimelineOptions); 
            long lastTweetId=0;
            //foreach (var tweet in tweets)
            //{
            //    lastTweetId = tweet.Id;
            //}
            return lastTweetId;
        }

        public void SetInitialCounters()
        {
            FollowRequests = initialFollowRequests;
            Mentions = initialMentions;
            Retweets = initialRetweets;
        }

        public void SendTweet(String status)
        { 
            var tweetoptions = new SendTweetOptions();
            tweetoptions.Status = status;
            service.SendTweet(tweetoptions);
        }

        public void UpdateCounters()
        {
            Retweets = GetRetweetsSinceLastTweet();
            FollowRequests = GetFollowRequests();
            Mentions = GetMentionsSinceLastTweet();
        }
    }
}
