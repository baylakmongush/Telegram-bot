using System;
using Telegram.Bot;
using System.IO;

namespace TelegramBot
{
    class Program
    {
        public static void Main(string[] args)
        {
            string token = File.ReadAllText(@"/Users/baylak/Projects/TelegramBot/TelegramBot/token.txt");
            TelegramBotClient botClient = new TelegramBotClient(token);
            Console.WriteLine($"@{botClient.GetMeAsync().Result.FirstName} start!");

            botClient.OnMessage += (s, arg) =>
            {
                Console.WriteLine($"{arg.Message.Chat.FirstName}: {arg.Message.Text}");
                botClient.SendTextMessageAsync(
                    chatId: arg.Message.Chat.Id,
                    text: $"Получено. {arg.Message.Text}",
                    replyToMessageId: arg.Message.MessageId
                    );
            };
            botClient.StartReceiving();
            Console.ReadLine();
        }
    }
}
