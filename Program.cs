using TurnBasedStrategy.Grid;

var position = new Position(2, 3);
var newPosition = position.Move(1, -1);

Console.WriteLine($"Original: {position}");
Console.WriteLine($"Moved: {newPosition}");

