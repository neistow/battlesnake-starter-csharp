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
### Rider 
2. You should install [Azure Toolkit](https://plugins.jetbrains.com/plugin/11220-azure-toolkit-for-rider).
3. Right click on Starter.Api and select "Publish" -> "Publish to Azure".
![rider64_dHp9DKUBkh](https://user-images.githubusercontent.com/55974615/84885040-270ffc80-b09b-11ea-8984-05bde8edf0b5.png)
![rider64_FcBaZNPtVG](https://user-images.githubusercontent.com/55974615/84885122-427b0780-b09b-11ea-9e3f-72290e2581a4.png)
4. Choose subscription type,location of server etc. If you have login error go to "Tools" -> "Azure" and login to your account
![rider64_SB5qMCBKTM](https://user-images.githubusercontent.com/55974615/84885239-6d655b80-b09b-11ea-8488-693e393f2050.png)
5. Click Publish and wait until a link to your app appears in console and/or opens in browser. At this point you've deployed your snake.
![rider64_1xs3suV3aB](https://user-images.githubusercontent.com/55974615/84885652-ff6d6400-b09b-11ea-88c6-72ed996c5554.png)
6. If you need to update your snake simply click "publish" and select existing app, after confirmation your snake will be updated and deployed automatically.

### Visual Studio
2. Right click on Starter.Api and select "Publish" -> "App Service" -> "Create New".
![nXystE79yb](https://user-images.githubusercontent.com/55974615/84887198-144af700-b09e-11ea-80b8-b69ea9bb2eb9.png)
3. Choose subscription type,location of server etc.
![devenv_jU0squqFWl](https://user-images.githubusercontent.com/55974615/84887068-ea91d000-b09d-11ea-8da4-6224543516f9.png)
4. Click Publish and wait until a link to your app appears in console and/or opens in browser. At this point you've deployed your snake.
![devenv_jK3BxfPRi3](https://user-images.githubusercontent.com/55974615/84887103-f54c6500-b09d-11ea-8fb7-254f041e95f6.png)
5. If you need to update your snake simply click "publish" and select existing app, after confirmation your snake will be updated and deployed automatically.

