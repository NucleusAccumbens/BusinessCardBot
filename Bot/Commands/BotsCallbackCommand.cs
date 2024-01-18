using Bot.Common.Abstractions;
using Bot.Messages;

namespace Bot.Commands;

public class BotsCallbackCommand : BaseCallbackCommand
{
    private readonly string _habrPhotoLink =
        "https://drive.google.com/file/d/1r9sOs0qpRLzWnCvZgOJA9eCcGg3tNWO1/view?usp=sharing";


    private readonly string _pricePhotoLink =
        "https://drive.google.com/file/d/1nhrWhAETMIRXK5wb_HKyx13vis15S1LG/view?usp=sharing";

    private readonly string _getJobPhotoLink =
        "https://drive.google.com/file/d/1YNInQKiWDUS4UifA2Rd1b23nFvc34wUf/view?usp=sharing";

    private readonly string _chaoPhotoLink =
        "https://drive.google.com/file/d/1-qOTEqGAgtmwstMmta3XCK-wsJiqCrif/view?usp=sharing";

    private readonly string _servicesPhotoLink =
        "https://drive.google.com/file/d/1Y1dngEGj77HwGij-o6vS16XXKBfuzXnY/view?usp=sharing";

    private readonly string _hariPhotoLink =
        "https://drive.google.com/file/d/1NqLy8coR34W4j6nwc4ABicSv7dYv-qeo/view?usp=sharing";

    private readonly string _cleanGoaPhotoLink =
        "https://drive.google.com/file/d/1d7Izvdkhb4Cz8pyBF0PJ6tCpqRvArEdy/view?usp=sharing";

    private readonly CvgetjobbotMessage _cvgetjobbotMessage = new();

    private readonly TeaClabChaoMessage _teaClabChaoMessage = new();

    private readonly StartMessage _startMessage = new();

    private readonly GoaServicesMessage _goaServicesMessage = new();

    private readonly HariMessage _hariMessage = new();

    private readonly CleanGoaMessage _cleanGoaMessage = new();

    private readonly HabrMessage _habrMessage = new();

    public override char CallbackDataCode => 'i';

    public override async Task CallbackExecute(Update update, ITelegramBotClient client)
    {
        if (update.CallbackQuery != null && update.CallbackQuery.Message != null)
        {
            long chatId = update.CallbackQuery.Message.Chat.Id;

            int messageId = update.CallbackQuery.Message.MessageId;

            if (update.CallbackQuery.Data == "iBuisness")
            {
                await _startMessage.EditMediaMessage(chatId, messageId, client,
                _pricePhotoLink);

                return;
            }
            if (update.CallbackQuery.Data == "iJobgetBot")
            {
                await _cvgetjobbotMessage.EditMediaMessage(chatId, messageId, client,
                _getJobPhotoLink);

                return;
            }
            if (update.CallbackQuery.Data == "iTeaClabChaoBot")
            {
                await _teaClabChaoMessage.EditMediaMessage(chatId, messageId, client,
                _chaoPhotoLink);

                return;
            }
            if (update.CallbackQuery.Data == "iServicesBot")
            {
                await _goaServicesMessage.EditMediaMessage(chatId, messageId, client,
                _servicesPhotoLink);

                return;
            }
            if (update.CallbackQuery.Data == "iHari")
            {
                await _hariMessage.EditMediaMessage(chatId, messageId, client,
                _hariPhotoLink);

                return;
            }
            if (update.CallbackQuery.Data == "iCleanGoa")
            {
                await _cleanGoaMessage.EditMediaMessage(chatId, messageId, client,
                _cleanGoaPhotoLink);

                return;
            }
            if (update.CallbackQuery.Data == "iHabr")
            {
                await _habrMessage.EditMediaMessage(chatId, messageId, client,
                _habrPhotoLink);

                return;
            }
        }
    }
}
