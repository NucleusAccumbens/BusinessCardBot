using Bot.Common.Abstractions;

namespace Bot.Messages;

public class CvgetjobbotMessage : BaseMessage
{
    public override string MessageText =>
        "<a href=\"https://t.me/cvjobget_bot\">Бот</a>, помогающий с поиском вакансий в сфере IT. " + 
        "Полезен как для работодателей, так и для соискателей.\r\n\r\n" + 
        "Функции:\n" + 
        "▫️ Создание резюме\n" + 
        "▫️ Создание вакансий\n" + 
        "▫️ Уведомления о появлении подходящих вакансий\n" + 
        "▫️ Парсинг вакансий из чатов\n" + 
        "...и другие функции";

    public override InlineKeyboardMarkup InlineKeyboardMarkup => new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "<<< ", callbackData: "iHabr"),
            InlineKeyboardButton.WithUrl(text: " 🤖 ", url: "https://t.me/cvjobget_bot"),
            InlineKeyboardButton.WithCallbackData(text: " >>>", callbackData: "iTeaClabChaoBot"),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "🔙 назад к визитке", callbackData: "iBuisness"),
        },
    });
}
