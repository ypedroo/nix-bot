using DSharpPlus;
using NixBot.Functions;

namespace NixBot;

public static class DiscordExtensions
{
    private static NixFunctions _nixFunctions;

    public static DiscordClient AddNixBot(this DiscordClient client)
    {
        _nixFunctions = new NixFunctions();
        _nixFunctions.Iniatialize(client);
        return client;
    }
}