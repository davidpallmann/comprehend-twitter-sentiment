//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Tweetinvi;
//using Tweetinvi.Models;

//// from https://wellsb.com/csharp/learn/getting-started-tweetinvi-dotnet-twitter

//namespace comprehend_twitter_sentiment
//{
//    public class TwitterHelper
//    {
//        private TwitterClient _twitterClient { get; set; }
//        public TwitterHelper(string apiKey, string apiSecret, string accessToken, string accessSecret)
//        {
//            _twitterClient = new TwitterClient(apiKey, apiSecret, accessToken, accessSecret);
//        }

//        public async Task<ITweet[]> SearchTweetsAsync(string query)
//        {
//            if (_twitterClient == null)
//                return null;

//            try
//            {
//                return await _twitterClient.Search.SearchTweetsAsync(query);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//    }
//}
