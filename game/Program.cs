using libs;
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Start Game");
        Console.WriteLine("2. Exit");
        Console.Write("Select an option: ");

        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
        {
            return;
        }
        else if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
        {
            Console.CursorVisible = false;
            Stopwatch gameTimer = new Stopwatch();
            TimeSpan gameDuration = TimeSpan.FromSeconds(20000);
            var runGame = true;
            var engine = GameEngine.Instance;
            var inputHandler = InputHandler.Instance;
            engine.Setup(false);
            // Timer
        
            // Main game loop
            while (runGame)
            {
                Console.Clear();
                if (!gameTimer.IsRunning)
                {
                    gameTimer.Start();
                }

                // Check if the game time has expired
                if (gameTimer.Elapsed >= gameDuration)
                {
                    // Stop the game
                    gameTimer.Stop();
                    Console.WriteLine("Game over! Time Ended;");
                    runGame =false;
                
                }

                // Calculate the remaining time and display it
                TimeSpan remainingTime = gameDuration - gameTimer.Elapsed;

                engine.Render();
                Console.WriteLine($"Time remaining: {remainingTime.TotalSeconds} seconds");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    inputHandler.Handle(keyInfo);
                }

                //Checks if it's the last level
                if (engine.currentLevel == 2 && engine.endGame() == false)
                {
                    engine.Render();
                    Console.WriteLine("Game finished. All levels mastered!");
                    runGame = false;

                    break;
                }

                if (engine.endGame() == false)
                {
                    engine.Render();
                    engine.currentLevel++;
                    engine.Setup(false);
                    Console.WriteLine("You escaped!");
                }
                // Add a delay
                Thread.Sleep(10);

            }
        }
    }
}