using TurnBasedStrategy.Entities;
using TurnBasedStrategy.Grid;

var grid = new GameGrid(5, 5);

var player = new Player();
var enemy = new Enemy();

grid.PlaceUnit(player, new Position(1, 1));
grid.PlaceUnit(enemy, new Position(3, 3));

Console.WriteLine($"Player at {player.Position}, HP: {player.HP}");
Console.WriteLine($"Enemy at {enemy.Position}, HP: {enemy.HP}");
