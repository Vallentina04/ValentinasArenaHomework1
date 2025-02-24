﻿using ArenaGameEngine;

namespace ArenaGameConsole
{
    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            RoyalHog royalHogs = new RoyalHogs("Deizy",55,33);
            IceWizard icewizard = new IceWizard("Gandalf",88,66);
            BabyDrago babyDrago = new BabyDrago("Drakaris", 44,66);


             Arena arena = new Arena(knight, rogue);
            arena.EventListener = new ConsoleGameEventListener();

            Console.WriteLine("Battle begins.");
            Hero winner = arena.Battle();
            Console.WriteLine($"Battle ended.  Winner is: {winner.Name}");
            Console.ReadLine();
        }
    }
}
