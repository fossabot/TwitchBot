# Simple Bot [![Build status](https://ci.appveyor.com/api/projects/status/k0cgg8xeqgh58uc7?svg=true)](https://ci.appveyor.com/project/SimpleSandman/twitchbot)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FSimpleSandman%2FTwitchBot.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2FSimpleSandman%2FTwitchBot?ref=badge_shield)
Custom chat bot for Twitch TV

This is an open-source console application with a .NET Core Web API that will benefit anyone who wants to have a foundation of making their own Twitch bot. This is primarly written in C#/SQL Server using an Azure SQL database from Microsoft. Currently, this bot is not end-user friendly because I'm concentrating on the logic of the bot first.

This bot has been revamped recently with a new configuration wizard that will allow new users to insert their credentials for the bot. For developers, please read further down for details on manually setting a dev configuration so the information is always saved.

Check out the wiki for the full list of commands by [clicking here](https://github.com/SimpleSandman/TwitchBot/wiki/List-of-Commands)!

The bot itself is an account on Twitch that I have made in order to have a custom bot name.

For a development environment (testing), create an `AppConfigSecrets.config` in the same folder as `App.config`. If you have any issues setting up this bot, please look further below for possible solutions.

## AppConfigSecrets.config

```xml
<TwitchBotConfiguration 
    botName="[BotName]" 
    broadcaster="[BroadcasterName]" 
    currencyType="[CurrencyName] (optional)" 
    discordLink="[DiscordLink]"
    enableDisplaySong="false"
    enableTweets="false"    
    libVLCAudioOutputDevice="[WindowsAudioOutputDevice]"
    regularFollowerHours="[RegularFollowerHours]"
    spotifyClientId="[SpotifyClientId]"
    spotifyRedirectUri="[SpotifyRedirectUri]"
    spotifyServerUri="[SpotifyServerUri]"
    streamLatency="[Latency] (in seconds)" 
    twitchBotApiLink="[TwitchBotApiLink]"
    twitchOAuth="[OAuth]" 
    twitchClientId="[ClientId]"
    twitchAccessToken="[AccessToken]" 
    twitterConsumerKey="[ConsumerKey]" 
    twitterConsumerSecret="[ConsumerSecret]"
    twitterAccessToken="[AccessToken]" 
    twitterAccessSecret="[AccessSecret]" 
    youTubeClientId="[YouTubeClientId]" 
    youTubeClientSecret="[YouTubeClientSecret]" 
    youTubeBroadcasterPlaylistId="[YouTubeBroadcasterPlaylistId]"
    youTubeBroadcasterPlaylistName="[YouTubeBroadcasterPlaylistName]" />
```

Set file to `copy-if-newer` so it's included in the compilation. For production, this file is not needed and the bot will ask for configuration on first run

## Possible Setup Issues:
- IIS HTTP Error 404.11 - Not Found `The request filtering module is configured to deny a request that contains a double escape sequence`
  - Add this line into the file: `C:\[PathToSolution]\.vs\config\applicationhost.config`
    ```xml
    <system.webServer>
        <security>
            <requestFiltering allowDoubleEscaping="true"/>
        </security>
    </system.webServer>
    ```
  - Workaround Source: https://stackoverflow.com/a/1453287/2113548
  - File Location Source: https://stackoverflow.com/q/12946476/2113548


## License
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2FSimpleSandman%2FTwitchBot.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2FSimpleSandman%2FTwitchBot?ref=badge_large)