using Bot.Common.Abstractions;

namespace Bot.Messages;

public class HariMessage : BaseMessage
{
    public override string MessageText =>
        "<a href=\"https://t.me/haridating_bot\">Hari</a> — это дейтинг-бот нового поколения.\n\n" +
        "Доступны следующие функции:\n" +
        "🔸 Регистрация\n" +
        "🔸 Добавьте фотографии\n" +
        "🔸 Просмотр профилей других пользователей\n" +
        "🔸 Отправка запросов на переписку\n\n" +
        "В разработке:\n" +
        "🔸 Анонимный приватный чат\n" +
        "🔸 Поиск по параметрам\n" +
        "🔸 Тест на знание ИППП";

    public override InlineKeyboardMarkup InlineKeyboardMarkup => new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "<<< ", callbackData: "iServicesBot"),
            InlineKeyboardButton.WithUrl(text: " 🤖 ", url: "https://t.me/haridating_bot"),
            InlineKeyboardButton.WithCallbackData(text: " >>>", callbackData: "iCleanGoa"),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "🔙 назад к визитке", callbackData: "iBuisness"),
        },
    });
}
