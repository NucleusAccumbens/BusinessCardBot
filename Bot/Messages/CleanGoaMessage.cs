using Bot.Common.Abstractions;

namespace Bot.Messages;

public class CleanGoaMessage : BaseMessage
{
    public override string MessageText =>
        "<a href=\"https://t.me/cleangoa_bot\">Блюститель чистоты</a> в Гоа.\n\n" +
        "🌿 Карта с пунктами приёма вторсырья\n" +
        "🌿 \"Стоп-картинки\" с информациях о штрафах за нарушении закона\n" +
        "🌿 Автоматическая рассылка сообщений о нарушении закона о сжигании мусора " +
        "в соответствующие инстанции\n" +
        "🌿 Афиша мероприятий и другая полезная информция";

    public override InlineKeyboardMarkup InlineKeyboardMarkup => new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "<<< ", callbackData: "iHari"),
            InlineKeyboardButton.WithUrl(text: " 🤖 ", url: "https://t.me/cleangoa_bot"),
            InlineKeyboardButton.WithCallbackData(text: " >>>", callbackData: "iHabr"),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "🔙 назад к визитке", callbackData: "iBuisness"),
        },
    });
}
