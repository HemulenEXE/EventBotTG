using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Configuration;
using System;
using EventBotTG.BotController;


TGBotController tgBot = new TGBotController();
await tgBot.Init(ConfigurationManager.AppSettings["tokenBot"] 
        ?? throw new Exception("Token bot not found, app.config is correct?"));