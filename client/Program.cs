using ServiceStack.Redis;
using System;
 
namespace client
{
    public class Program
    {
        const string ChannelName = "messages";

        public static void Main(string[] args)
        {
            using (var redisConsumer = new RedisClient("redis"))
            using (var subscription = redisConsumer.CreateSubscription())
            {
                subscription.OnSubscribe = channel =>
                {
                    Console.WriteLine(String.Format("Subscribed to '{0}'", channel));
                };
                subscription.OnUnSubscribe = channel =>
                {
                    Console.WriteLine(String.Format("UnSubscribed from '{0}'", channel));
                };
                subscription.OnMessage = (channel, msg) =>
                {
                    Console.WriteLine(msg);
                };

                Console.WriteLine(String.Format("Started Listening On '{0}'", ChannelName));
                subscription.SubscribeToChannels(ChannelName); //blocking
            }
        }

    }
}
