using DSharpPlus;
using DSharpPlus.EventArgs;

namespace NixBot.Functions;

public class NixFunctions
{
    public void Iniatialize(DiscordClient client)
    {
        client.MessageCreated += OnMessageCreated;
    }

    private async Task OnMessageCreated(DiscordClient discordClient, MessageCreateEventArgs args)
    {
        if (args.Message.Content.StartsWith("help"))
        {
            await discordClient.SendMessageAsync(args.Channel, $@"Ola {args.Author.Username}, 
            Para visualizar os acessos e começar seus estudos acesse o canal #acessos.
            Semanalmente sinta-se livre para marcar um momento com um de nossos instrutores (nomes em verde).
            No mais bom estudo e precisando só chamar");
        }
    }
}