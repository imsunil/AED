using System;
using System.Configuration;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using TweetSharp.Model;

namespace TryTweet
{
    class Program
    {
        static void Main(string[] args)
        {
            TwitterClientInfo twitterClientInfo = new TwitterClientInfo(); 
            twitterClientInfo.ConsumerKey = ConsumerKey; //Read ConsumerKey out of the app.config 
            twitterClientInfo.ConsumerSecret = ConsumerSecret; //Read the ConsumerSecret out the app.config  
            TwitterService twitterService = new TwitterService(twitterClientInfo); 

            //Firstly we need the RequestToken and the AuthorisationUrl 

OAuthToken requestToken = twitterService.GetRequestToken();
//OAuthToken requestToken = Hammock.Authentication.OAuth
string authUrl = twitterService.GetAuthorizationUrl(requestToken); 



//authUrl is just a URL we can open IE and paste it in if we want 

Console.WriteLine("Please Allow This App to send Tweets on your behalf"); 
Process.Start(authUrl); //Launches a browser that'll go to the AuthUrl. 

   

//Allow the App 

Console.WriteLine("Enter the PIN from the Browser:"); 

string pin = Console.ReadLine(); 

  

OAuthToken accessToken = twitterService.GetAccessToken(requestToken, pin); 

  

string token = accessToken.Token; //Attach the Debugger and put a break point here 

string tokenSecret = accessToken.TokenSecret; //And another Breakpoint here 

   

Console.WriteLine("Write Down The AccessToken: " + token); 

Console.WriteLine("Write Down the AccessTokenSecret: " + tokenSecret); 

   

   

   

Console.ReadLine(); 


        }
        #region ConsumerKey & ConsumerSecret 

private static string ConsumerSecret 

{ 

get { return ConfigurationManager.AppSettings["ConsumerSecret"]; } 

} 

   

private static string ConsumerKey 

{ 

get { return ConfigurationManager.AppSettings["ConsumerKey"]; } 

} 

#endregion 
} 

} 


    

