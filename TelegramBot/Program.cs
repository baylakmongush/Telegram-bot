using System;
using Telegram.Bot;
using System.IO;

namespace TelegramBot
{
    class Program
    {
        public static void Main(string[] args)
        {
            string token = "1185273900:AAGIHqz13UiyYsXNg3Mi2AtZAjxrpBiNfR4";
            TelegramBotClient botClient = new TelegramBotClient(token);
            Console.WriteLine($"@{botClient.GetMeAsync().Result.FirstName} start!");

            botClient.OnMessage += (s, arg) =>
            {
                Console.WriteLine($"{arg.Message.Chat.FirstName}: {arg.Message.Text}");
                if (arg.Message.Text == "я Хлебушек")
                botClient.SendStickerAsync(
                chatId: arg.Message.Chat,
                sticker: "https://github.com/TelegramBots/book/raw/master/src/docs/sticker-fred.webp"
                );
                else
                {
                    botClient.SendTextMessageAsync(
                    chatId: arg.Message.Chat,
                    text: "Ты не Хлебушек"
                    );
                }
            };
            botClient.StartReceiving();
            Console.ReadLine();
            botClient.StopReceiving();
        }
    }
}
