using System;
using WCFClient.WCFExampleClient;

namespace WCFClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Ask the Magic 8 Ball *****\n");

            using (var ball = new EightBallClient("NetTcpBinding_IEightBall"))
            {
                Console.Write("Your question: ");
                var question = Console.ReadLine();
                var answer = ball.ObtainAnswerToQuestion(question);

                Console.WriteLine("8-Ball says: {0}", answer);
            }

            Console.ReadLine();
        }
    }
}