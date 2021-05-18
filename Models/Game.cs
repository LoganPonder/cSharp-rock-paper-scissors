using System;
using System.Collections.Generic;

namespace cs_rock_paper_scissors.Models
{
    public class Game
    {
      public string play(string computer, string player)
      {
          var win = new Dictionary<string, string> {
              {"Paper", "Rock"},
              {"Scissors", "Paper"},
              {"Rock", "Scissors"}
          };
        if(win[player].Contains(computer)) {
            Console.WriteLine($"You win, {player} beats {computer}!");
            return "win";
        } else if(computer == player) {
            Console.WriteLine("You tie, play again?");
            return "tie";
        } else {
            Console.WriteLine($"You loose, {computer} beats {player}!");
            return "lose";
        }
      }
    // public Game()
    // {

    // }
    }
}