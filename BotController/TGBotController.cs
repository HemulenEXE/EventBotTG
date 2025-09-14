using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace EventBotTG.BotController
{
    public class TGBotController : IDisposable
    {
        private CancellationTokenSource _cts;
        private TelegramBotClient _botClient;

        private void Retention()
        {
            Console.WriteLine("Press any key, to terminate tg client");
            Console.ReadLine();
            Dispose();

        }

        public void Dispose()
        {
            _cts?.Cancel();
        }
        public async Task Init(string tokenBot)
        {
            _botClient = new TelegramBotClient($"{tokenBot}", cancellationToken: _cts.Token);
            var me = await _botClient.GetMe();
            Console.WriteLine($"@{me.Username} is running...");
            _botClient.OnMessage += OnMessage;
            _botClient.OnError += OnError;
            _botClient.OnUpdate += OnUpdate;
            Retention();
        }

        public TGBotController()
        {
            _cts = new CancellationTokenSource();
        }

        // method that handle messages received by the bot:
        async private Task OnMessage(Message msg, UpdateType type)
        {
            if (msg.Text == "/start")
            {
                await _botClient.SendMessage(msg.Chat, "Welcome! Pick one direction",
                    replyMarkup: new InlineKeyboardButton[] { "Left", "Right" });
            }
        }

        // method to handle errors in polling or in your OnMessage/OnUpdate code
        async private Task OnError(Exception exception, HandleErrorSource source)
        {
            Console.WriteLine(exception.ToString(), source); // just dump the exception to the console
        }
        // method that handle other types of updates received by the bot:
        async private Task OnUpdate(Update update)
        {
            if (update is { CallbackQuery: { } query }) // non-null CallbackQuery
            {
                await _botClient.AnswerCallbackQuery(query.Id, $"You picked {query.Data}"); // Вывод уведомления как push app надпись по середине экрана
                await _botClient.SendMessage(query.Message!.Chat, $"User {query.From} clicked on {query.Data}"); // ответ в чат
            }
        }

        
    }
}