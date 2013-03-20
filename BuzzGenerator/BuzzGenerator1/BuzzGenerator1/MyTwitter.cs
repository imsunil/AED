﻿using System;
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
        }

        public void InitializeMetrics()
        {
            //lastTweetID = GetLastTweetID(); Disabled to avoid dynamically setting it
            Retweets=initialRetweets=GetRetweetsSinceLastTweet();
            Mentions=initialMentions = GetMentionsSinceLastTweet();
            FollowRequests = initialFollowRequests = GetFollowRequests();
        }



        private int GetFollowRequests()
        {
            int followers=0;
            var followerLists = service.GetIncomingFriendRequests(new GetIncomingFriendRequestsOptions());
            foreach (var follower in followerLists)
            {
                followers = followers + 1;
            }
            return  followers;
        }

        private int GetMentionsSinceLastTweet()
        {
            ListTweetsMentioningMeOptions myMentionOptions = new ListTweetsMentioningMeOptions();
            myMentionOptions.Count = 200;
            myMentionOptions.SinceId = lastTweetID;
            int mentions = 0;
            var tweets = service.ListTweetsMentioningMe(myMentionOptions);
            foreach (var tweet in tweets)
            {
                mentions = mentions + 1;
            }
            return mentions;
        }

        private int GetRetweetsSinceLastTweet()
        {

            ListRetweetsOfMyTweetsOptions myRetweetOptions = new ListRetweetsOfMyTweetsOptions();
            myRetweetOptions.SinceId = lastTweetID;
            myRetweetOptions.Count = 100;
            var tweets = service.ListRetweetsOfMyTweets(myRetweetOptions);
            int retweets = 0;
            foreach (var tweet in tweets)
            {
                retweets = retweets + 1;
                initialTotalRetweets = initialTotalRetweets + tweet.RetweetCount;
            }
            return retweets;
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