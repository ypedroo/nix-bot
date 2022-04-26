FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NixBot/NixBot.csproj", "NixBot/"]
RUN dotnet restore "NixBot/NixBot.csproj"
COPY . .
WORKDIR "/src/NixBot"
RUN dotnet build "NixBot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NixBot.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NixBot.dll"]
