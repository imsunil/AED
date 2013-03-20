using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using TweetSharp;
using TweetSharp.Model;
using System.Xml;
using Newtonsoft.Json;



namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //OAuthInfo myOAuth =  new OAuthInfo();
            //myOAuth.ConsumerKey = "8TmvHbMNWugTpk9lIpbdQ";
            //myOAuth.ConsumerSecret = "AmDxGd29eSUjERuyy20p5bZaFrpLfgYTCP5Qi1K0crw";
            //myOAuth.AccessToken = "21985278-14mhmDF5238JlIeA68ak2MudVhXuHsmkhsNoMTDsp";
            //myOAuth.AccessSecret = "MTpjzzkibGWM6KU8Za2B4WJUieskPEjrAVxBhY2oQ";

            //TinyTwitter TT = new TinyTwitter(new OAuthInfo());

            //IEnumerable<Tweet> mytimneline = TT.GetHomeTimeline(null, 2);
            //Console.ReadKey();

<<<<<<< HEAD
            var service = new TwitterService("tedRo766zL7mr7TKZkOugA", "WREOp5SZ71EtLCt3T4RboUv1IrkUpPkCpcBxkAGk8");
            //var service = new TwitterService("bWDpCLO2mIByqMYoaRh2Cg", "X4veUKVWhB09wipWhVpaVhXvLDHqzIjnOLOGXxiY8Y");
            service.AuthenticateWith("21985278-dud1wSertHCQYTUK5ta5AA0ciqWB31ZsT8Dt8DJg", "yPDp2TTOOhQj6XDxX7P5TxmNtHZcQ6sJumth8DVzRk");
            //service.AuthenticateWith("25963011-QuJkeaEcXqB92bhMxoIJHKBLFHP1rPZysu6K68IqZ", "pY0TXRW8aIUSDfSUpJAzsQ2s2Oay2A0HBdiaK1Z8");
            //var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
=======
            //var service = new TwitterService("tedRo766zL7mr7TKZkOugA", "WREOp5SZ71EtLCt3T4RboUv1IrkUpPkCpcBxkAGk8");
            var service = new TwitterService("bWDpCLO2mIByqMYoaRh2Cg", "X4veUKVWhB09wipWhVpaVhXvLDHqzIjnOLOGXxiY8Y");
            //service.AuthenticateWith("21985278-dud1wSertHCQYTUK5ta5AA0ciqWB31ZsT8Dt8DJg", "yPDp2TTOOhQj6XDxX7P5TxmNtHZcQ6sJumth8DVzRk");
            service.AuthenticateWith("25963011-QuJkeaEcXqB92bhMxoIJHKBLFHP1rPZysu6K68IqZ", "pY0TXRW8aIUSDfSUpJAzsQ2s2Oay2A0HBdiaK1Z8");
             //var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
            var tweets = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions());

>>>>>>> added modifications for tweet insights
            //var tweets = service.ListRetweetsOfMyTweets(new ListRetweetsOfMyTweetsOptions());
            //var tweets = service.ListFavoriteTweets(new ListFavoriteTweetsOptions());
            //var tweets = service.ListTweetsMentioningMe(new ListTweetsMentioningMeOptions());

            //var MyTweetOptions = new SendTweetOptions();
            //MyTweetOptions.Status = "Hello World";

            //service.SendTweet(MyTweetOptions);
            
            var myFriendLists = service.GetIncomingFriendRequests(new GetIncomingFriendRequestsOptions());

            foreach (var FriendLists in myFriendLists)
            {
                var MyFriendOptions = new GetUserProfileForOptions();
                MyFriendOptions.UserId = FriendLists;

                var MyFriend = service.GetUserProfileFor(MyFriendOptions);


<<<<<<< HEAD
                Console.WriteLine("{0} says", FriendLists.ToString());
=======
            //Console.WriteLine(" count: {0}") tweets.Count.ToString());
            int count = 0;
            foreach (var tweet in tweets)
            {
                
                count = count + 1;

                Console.WriteLine("{0} says '{1}' count: {2}", tweet.Id, tweet.Text,count.ToString());
>>>>>>> added modifications for tweet insights
                Console.ReadKey();
                

            }

            //foreach (var tweet in tweets)
            //{
            //    Console.WriteLine("{0} says '{1}'", tweet.Id, tweet.Text);
            //    Console.ReadKey();

            //}

            //using TweetSharp;

// Pass your credentials to the service
 //           TwitterService service = new TwitterService("bWDpCLO2mIByqMYoaRh2Cg", "X4veUKVWhB09wipWhVpaVhXvLDHqzIjnOLOGXxiY8Y");

// Step 1 - Retrieve an OAuth Request Token
//OAuthRequestToken requestToken = service.GetRequestToken();

// Step 2 - Redirect to the OAuth Authorization URL
//Uri uri = service.GetAuthorizationUri(requestToken);
//Process.Start(uri.ToString());

// Step 3 - Exchange the Request Token for an Access Token
//string verifier = Console.ReadLine(); // <-- This is input into your application by your user
//OAuthAccessToken access = service.GetAccessToken(requestToken, verifier);

// Step 4 - User authenticates using the Access Token
//service.AuthenticateWith(access.Token, access.TokenSecret);
//IEnumerable<TwitterStatus> mentions = service.ListTweetsMentioningMe);

//var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
//var myRetweetsOption = new ListRetweetsOfMyTweetsOptions();
//myRetweetsOption.SinceId = 313064862320300032;
//tweets = service.ListRetweetsOfMyTweets(myRetweetsOption);
//
//foreach (var tweet in tweets)
//{
    //Console.WriteLine("{0} says '{1}' id:{3} ", tweet.User.ScreenName, tweet.Text, tweet.Id);
  //  Console.WriteLine("{0} says '{1}' ", tweet.Id, tweet.Text);
    //Console.ReadKey();

//}
//Console.ReadKey();

        }
   }
}
