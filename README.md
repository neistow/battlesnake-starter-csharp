# [Battlesnake](https://play.battlesnake.com) C# Starter

This is a basic implementation of the Battlesnake API. It's a great starting point for anyone wanting to program their first Battlesnake using C#. 
It can also be deployed to Azure, or any other cloud provider you'd like.

### Technologies Used

* [Asp Net Core](https://dotnet.microsoft.com/apps/aspnet)

## Prerequisites

* [Battlesnake Account](https://play.battlesnake.com)
* [Azure Account](https://azure.microsoft.com/en-us/)
* [GitHub Account](https://github.com) (Optional)

## Running Your Battlesnake on [Azure](https://azure.microsoft.com/en-us/)

For a quick setup you'll need a [Rider](https://www.jetbrains.com/rider/) or [Visual Studio](https://visualstudio.microsoft.com/)

1. Clone this repository and open it in any mentioned IDE
```
https://github.com/neistow/battlesnake-starter-csharp.git
```
2. If you are using Rider you should also install [Azure Toolkit](https://plugins.jetbrains.com/plugin/11220-azure-toolkit-for-rider).
3. Right click on Starter.Api and select "Publish" -> "Publish to Azure". (If you are using VS, you should select "App Service" in dialog window)
4. Next you will need to choose subscription type,location of server etc.
5. Click Publish and wait until a link to your app appears in console and/or opens in browser. At this point you've deployed your snake.
6. If you need to update your snake simply click "publish" and select existing app, after confirmation your snake will be updated and deployed automatically.
