using Bot.Common.Abstractions;

namespace Bot.Messages;

public class StartMessage : BaseMessage
{
    public override string MessageText =>
        "<a href=\"https://t.me/noncredist\">Напишите мне</a>, чтобы обсудить ваши задачи, " +
        "и я найду решение специально для вас.\r\n\r\n" +
        "Что вы получите:\r\n" +
        "✔️ Четкую коммуникацию в процессе работы\r\n" +
        "✔️ Бесплатную техподдержку первые два месяца после запуска бота\r\n" +
        "✔️ Исходный код\r\n" +
        "✔️ Сэкономленное благодаря автоматизации время\r\n\r\n";

    public override InlineKeyboardMarkup InlineKeyboardMarkup => new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithUrl(text: "🖍 НАПИСАТЬ", url: "https://t.me/noncredist"),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(text: "🤖 ПОРТФОЛИО", callbackData: "iJobgetBot"),
        },
    });
}
