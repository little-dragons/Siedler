# Siedler

This shall eventually be a multiplayer real-time strategy game where you manage a small group of settlers (german: Siedler) who build houses, work in mines, fish for food, cut wood, research in monasteries, train to be soldiers in the barracks etc.

The goal is to collect more victory points than your opponents to win the game.

## Programming

The game is written in C# against .NET8. It uses a a self-written engine (Lini) using self-generated OpenGL bindings.
To start the game, do `dotnet run --project Source/Client/` from the root directory. Starting from the root directory is required to automatically resolve the resource path variable. Alternatively, a launch task for vscode is configured which correctly initializes this variable.