Console.WriteLine("--- Press ENTER to start game ---");
ConsoleKeyInfo startGame = Console.ReadKey(true);
while (startGame.Key != ConsoleKey.Enter)
{
    startGame = Console.ReadKey(true);
}
Console.Clear();
Console.WriteLine("It's dark and you are alone at the beach.");
Thread.Sleep(2000);
Console.WriteLine("There is only one way out of there. Be careful, there may be orcs are around.");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Press 'F' to pick up the longsword laying in the sand");
ConsoleKeyInfo pickUp = Console.ReadKey(true);
while (pickUp.Key != ConsoleKey.F)
{
    pickUp = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("You picked up the longsword and are ready to fight and defend yourself.");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Press 'W' to walk further down the beach");
ConsoleKeyInfo walk = Console.ReadKey(true);
while (walk.Key != ConsoleKey.W)
{
    walk = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("Walking further down the beach...");
Thread.Sleep(2000);
Console.WriteLine("It's so dark, you can barely see what's ahead of you...");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Press 'W' to keep walking");
walk = Console.ReadKey(true);
while (walk.Key != ConsoleKey.W)
{
    walk = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("Keeps walking...");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Something bright and orange that looks like a fire torch is");
Console.WriteLine("to see further down the beach...");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Press 'W' to walk towards it");
walk = Console.ReadKey(true);
while (walk.Key != ConsoleKey.W)
{
    walk = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("Walking towards the bright and orange light...");
Thread.Sleep(2000);
Console.WriteLine("A fire torch is hanging on the stonewall.");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Press 'F' to pick it up and then 'W' to keep walking");
pickUp = Console.ReadKey(true);
while (pickUp.Key != ConsoleKey.F)
{
    pickUp = Console.ReadKey(true);
}
walk = Console.ReadKey(true);
while (walk.Key != ConsoleKey.W)
{
    walk = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("You picked up the fire torch and walks further down the dark beach...");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("The fog gets thicker and thicker...");
Thread.Sleep(2000);
Console.WriteLine("Steps coming from behind...");
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Press 'T' to turn around!");
ConsoleKeyInfo turnAround = Console.ReadKey(true);
while (turnAround.Key != ConsoleKey.T)
{
    turnAround = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("You got knocked down! The leader of the orcs URZOG has arrived!");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine("---------- URZORG ----------");
Console.WriteLine();
Console.WriteLine("HP: 100");
Console.WriteLine();
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("URZORG: *SWINGS HIS SPIKE CLUB TOWARDS YOU!*");
Console.WriteLine();
Console.WriteLine("Press 'D' to dodge the incoming strike!");
ConsoleKeyInfo dodge = Console.ReadKey(true);
while (dodge.Key != ConsoleKey.D)
{
    dodge = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("*dodged the incoming strike*");
Console.WriteLine();
Console.WriteLine("Press 'A' to attack back!");
ConsoleKeyInfo attack = Console.ReadKey(true);
while (attack.Key != ConsoleKey.A)
{
    attack = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("*attacking back*");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("---------- URZORG ----------");
Console.WriteLine();
Console.WriteLine("HP: 75");
Console.WriteLine();
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("URZORG: *GRABS YOU!*");
Console.WriteLine();
Console.WriteLine("Press 'A' to attack his arms holding you then 'E' to escape his arms!");
attack = Console.ReadKey(true);
while (attack.Key != ConsoleKey.A)
{
    attack = Console.ReadKey(true);
}
ConsoleKeyInfo escape = Console.ReadKey(true);
while (escape.Key != ConsoleKey.E)
{
    escape = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("*attacking his arms and escaping his grip*");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("---------- URZORG ----------");
Console.WriteLine();
Console.WriteLine("HP: 50");
Console.WriteLine();
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("URZORG: *THROWS A BIG ROCK TOWARDS YOU!*");
Console.WriteLine();
Console.WriteLine("Press 'D' to dodge the big rock!");
dodge = Console.ReadKey(true);
while (dodge.Key != ConsoleKey.D)
{
    dodge = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("*dodged the big rock*");
Console.WriteLine();
Console.WriteLine("Press 'J' to jump on the big rock!");
ConsoleKeyInfo jump = Console.ReadKey(true);
while (jump.Key != ConsoleKey.J)
{
    jump = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("*jumping on the big rock*");
Console.WriteLine();
Console.WriteLine("Press 'J' then 'A' to jump from the big rock and cut his head off!");
jump = Console.ReadKey(true);
while (jump.Key != ConsoleKey.J)
{
    jump = Console.ReadKey(true);
}
attack = Console.ReadKey(true);
while (attack.Key != ConsoleKey.A)
{
    attack = Console.ReadKey(true);
}
Console.WriteLine();
Console.WriteLine("*jumping from the big rock and cutting his head off*");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
Console.WriteLine("  YOU DEFEATED URZORG AND COMPLETED THE GAME.  ");
Console.WriteLine();
Console.WriteLine("----------------------------------------------");
Console.WriteLine();
Console.WriteLine("Press ESC to close the game...");
ConsoleKeyInfo closeGame = Console.ReadKey(true);
while (closeGame.Key != ConsoleKey.Escape)
{
    closeGame = Console.ReadKey(true);
}
