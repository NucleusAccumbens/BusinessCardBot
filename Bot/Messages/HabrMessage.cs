using Bot.Common.Abstractions;

namespace Bot.Messages;

public class HabrMessage : BaseMessage
{
    public override string MessageText =>
        "<a href=\"https://t.me/habrfreelancescraper_bot\">Бот-скрапер</a> проектов с " +
        "<a href=\"https://freelance.habr.com/projects\">Habr freelanse</a>.\n\n" +
        "Ищет проекты по ключевым словам и присылает их в бот.";

    public override InlineKeyboardMarkup InlineKeyboardMarkup => new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "<<< ", callbackData: "iCleanGoa"),
            InlineKeyboardButton.WithUrl(text: " 🤖 ", url: "https://t.me/habrfreelancescraper_bot"),
            InlineKeyboardButton.WithCallbackData(text: " >>>", callbackData: "iJobgetBot"),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "🔙 назад к визитке", callbackData: "iBuisness"),
        },
    });
}
