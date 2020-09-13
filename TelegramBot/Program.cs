using System;
using Telegram.Bot;

namespace TelegramBot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string token = "1113687191:AAGDtRxsVtYlr_eEv52fweYYvBW_8XIRpTg";
            TelegramBotClient botClient = new TelegramBotClient(token);
            Console.WriteLine(botClient.GetMeAsync().Result.FirstName);
        }
    }
}
