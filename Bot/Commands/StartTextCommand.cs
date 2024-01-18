using Application.TlgUsers.Interfaces;
using Bot.Common.Abstractions;
using Bot.Common.Services;
using Bot.Messages;
using Domain.Entities;

namespace Bot.Commands;

public class StartTextCommand : BaseTextCommand
{
    private readonly string _photoLink = "https://drive.google.com/file/d/1nhrWhAETMIRXK5wb_HKyx13vis15S1LG/view?usp=sharing";

    private readonly StartMessage _startMessage = new();

    private readonly ICheckUserIsInDbQuery _checkUserIsInDbQuery;

    private readonly ICreateTlgUserCommand _createTlgUserCommand;

    public StartTextCommand(ICheckUserIsInDbQuery checkUserIsInDbQuery, ICreateTlgUserCommand createTlgUserCommand)
    {
        _checkUserIsInDbQuery = checkUserIsInDbQuery;
        _createTlgUserCommand = createTlgUserCommand;
    }

    public override string Name => "/start";

    public override async Task Execute(Update update, ITelegramBotClient client)
    {
        if (update.Message != null)
        {
            long chatId = update.Message.Chat.Id;
            
            bool oldUser = await _checkUserIsInDbQuery
                .CheckUserIsInDbAsync(chatId);

            if (!oldUser) { await _createTlgUserCommand.CreateTlgUserAsync(new TlgUser()
            {
                ChatId = chatId,
                Username = update.Message.Chat.Username
            });}

            await _startMessage.SendPhoto(chatId, client, _photoLink);
        }
    }
}
