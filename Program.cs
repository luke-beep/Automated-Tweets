using Tweetinvi;

namespace Automated_Tweets
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Null Check
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            #endregion

            string tweetText = GetRandomTweet();
            PostTweet(tweetText);
            Console.WriteLine("Tweet sent: " + tweetText);
            Console.ReadLine();
        }

        static string GetRandomTweet()
        {
            #region Tweet Lines
            string[] tweetOptions = {
                "Did you know that the first computer was invented in 1936? #computers #history",
                "The future is here! Artificial intelligence and machine learning are changing the world. #AI #ML #computers",
                "The importance of cybersecurity can't be overstated. Keep your computer and online accounts secure. #cybersecurity #computers",
                "Computer programming is the language of the future. Learning to code can open up a world of possibilities. #coding #computers",
                "Computer hardware is constantly improving. Stay up-to-date with the latest advancements in technology. #hardware #computers",
                "Computer software is the backbone of the modern world. Learn more about the software that powers your computer. #software #computers",
                "The internet is a vast network of computers. Learn more about how the internet works. #internet #computers",
                "The first computer virus was created in 1983. Learn more about the history of computer viruses. #virus #computers",
                "The first computer mouse was invented in 1964. Learn more about the history of computer mice. #mouse #computers",
                "The first computer keyboard was invented in 1871. Learn more about the history of computer keyboards. #keyboard #computers",
                "The first computer monitor was invented in 1927. Learn more about the history of computer monitors. #monitor #computers",
                "The first computer printer was invented in 1968. Learn more about the history of computer printers. #printer #computers",
                "The first computer game was invented in 1951. Learn more about the history of computer games. #game #computers",
                "The first computer mouse was invented in 1964. Learn more about the history of computer mice. #mouse #computers"
            };
            #endregion
            int randomIndex = new Random().Next(tweetOptions.Length);
            return tweetOptions[randomIndex];
        }

        static async void PostTweet(string tweetText)
        {
            #region Settings
            var apiKey = "api_key";
            var apiSecret = "api_secret";
            var accessToken = "access_token";
            var accessTokenSecret = "access_token_secret";
            #endregion
            var userClient = new TwitterClient(apiKey, apiSecret, accessToken, accessTokenSecret);
            #region Send Tweet
            await userClient.Tweets.PublishTweetAsync(tweetText);
            #endregion
        }

    }
}