using DSharpPlus;
using Microsoft.Extensions.Configuration;
using NixBot;

var source = new CancellationTokenSource();

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", true)
    .AddUserSecrets(typeof(Program).Assembly, true)
    .Build();

var client = new DiscordClient(new DiscordConfiguration
{
    Token = config["discord-token"],
    TokenType = TokenType.Bot
});

client.AddNixBot();

var token = source.Token;
await client.ConnectAsync();

while (!token.IsCancellationRequested)
{
    await Task.Delay(100);
}
