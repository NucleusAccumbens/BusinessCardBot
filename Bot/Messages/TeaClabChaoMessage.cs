using Bot.Common.Abstractions;

namespace Bot.Messages;

public class TeaClabChaoMessage : BaseMessage
{
    public override string MessageText =>
        "С помощью этого <a href=\"https://t.me/teaclubchao_bot\">бота</a> вы сможете ознакомиться " +
        "с ассортиментом магазина и оформить заказ. " +
        "Доступен выбор способа получения и способ оплаты.\n\n" +
        "Администратор может добавлять и редактировать товары, " +
        "а также создавать скидки. " +
        "Администратор получает оповещение о новых заказах в чате с ботом.\n\n" +
        "Доступен на двух языках.";

    public override InlineKeyboardMarkup InlineKeyboardMarkup => new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "<<< ", callbackData: "iJobgetBot"),
            InlineKeyboardButton.WithUrl(text: " 🤖 ", url: "https://t.me/teaclubchao_bot"),
            InlineKeyboardButton.WithCallbackData(text: " >>>", callbackData: "iServicesBot"),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "🔙 назад к визитке", callbackData: "iBuisness"),
        },
    });
}
