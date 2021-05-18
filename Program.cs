using System;
using System.Collections.Generic;
// using System.Threading;
using cs_rock_paper_scissors.Models;

namespace cs_rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            bool playing = true;
            List<string> choices = new List<string>(){
                "Rock",
                "Paper",
                "Scissors"
            };

            var game = new Game();
            while(playing) {
                Random randomNum = new Random();
                var index = randomNum.Next(0, 3);
                var computerChoice = choices[index];
                Console.WriteLine("What have you chosen? Rock, Paper, or Scissors?");
                var playerChoice = Console.ReadLine();

                if(choices.Contains(playerChoice)) {
                    game.play(computerChoice, playerChoice);
                } else {
                    Console.WriteLine("Not a valid attack, choose Rock, Paper, or Scissors!");
                }
            }
        }
    }
}
