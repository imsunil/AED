using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TryingTinyTwitter
{
    class Program
    {
        static void Main(string[] args)
        {
            //OAuthInfo myOAuth = new OAuthInfo();
            //myOAuth.ConsumerKey = "";
            //myOAuth.ConsumerSecret = "";
            //myOAuth.AccessSecret = "";
            //myOAuth.AccessToken = "";

            //var myOauth = new

            //TinyTwitter TT = new TinyTwitter(new OAuthInfo());

            //IEnumerable<Tweet> mytimneline = TT.GetHomeTimeline(null, 2);
            var oauth = new OAuthInfo
            {
                AccessToken = "21985278-dud1wSertHCQYTUK5ta5AA0ciqWB31ZsT8Dt8DJg",
                AccessSecret = "yPDp2TTOOhQj6XDxX7P5TxmNtHZcQ6sJumth8DVzRk",
                ConsumerKey = "tedRo766zL7mr7TKZkOugA",
                ConsumerSecret = "WREOp5SZ71EtLCt3T4RboUv1IrkUpPkCpcBxkAGk8"
            };

            var twitter = new TinyTwitter(oauth);

            //// Update status, i.e, post a new tweet
            //twitter.UpdateStatus("I'm tweeting from C#");

            // Get home timeline tweets
            var tweets = twitter.GetUserTimeline(null, 5);

            //twitter.UpdateStatus("First tweet from my program");
           // twitter.UpdateStatus("First tweet from my program");
            foreach (var tweet in tweets)
                Console.WriteLine("{0}: {1}: {2}", tweet.UserName, tweet.Text, tweet.Id);
           
            
            Console.ReadKey();


        }
    }
}
