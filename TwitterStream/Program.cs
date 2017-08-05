using System;
using Tweetinvi;

namespace TwitterStream {
    class Program {
        static void Main(string[] args) {

            // Set up twitter credentials (https://apps.twitter.com)
            Auth.SetUserCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");

            var stream = Stream.CreateFilteredStream();
            stream.AddTrack("cats");
            stream.MatchingTweetReceived += (sender, eventArgs) => {
                Console.WriteLine("A tweet about cats has been found; the tweet is '" + eventArgs.Tweet.ToJson() + "'");
            };
            stream.StartStreamMatchingAllConditions();
        }
    }
}