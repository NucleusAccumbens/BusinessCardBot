using Bot.Common.Abstractions;

namespace Bot.Messages;

public class GoaServicesMessage : BaseMessage
{
    public override string MessageText =>
        "<a href=\"https://t.me/goaservices_bot\">Бот-помощник</a> для поиска и размещения услуг в Гоа.\n\n" +
        "✨ Добавление и поиск услуг по категориям\n" +
        "✨ Поиск по ключевым словам\n" +
        "✨ Администратор может создавать опросы (пользователь может отписаться от рассылки)\n\n" +
        "Бот регулярно обновляется.";

    public override InlineKeyboardMarkup InlineKeyboardMarkup => new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "<<< ", callbackData: "iTeaClabChaoBot"),
            InlineKeyboardButton.WithUrl(text: " 🤖 ", url: "https://t.me/goaservices_bot"),
            InlineKeyboardButton.WithCallbackData(text: " >>>", callbackData: "iHari"),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "🔙 назад к визитке", callbackData: "iBuisness"),
        },
    });
}
