using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombGame
{
    class StartBombGame
    {
        static void Main(string[] args)
        {
            //TODO: Handle exceptions,  add user input check
            Console.WindowHeight = 14;
            Console.SetBufferSize(80,14);

        //
            bool play = true;
            GameCore game = new GameCore();
            while (play = true)
            {            
              game.Draw();
              Console.WriteLine();
              Console.WriteLine("to restart the game type \"restart\"");
              Console.WriteLine("give me something like /A1/: ");
             
              string reader = Console.ReadLine();
              reader = reader.Trim();
              if (reader == "restart")
              {
                  game.LoadGrounds();

              }
              else
              {
                  game.Checker(reader);
              }
            }

           
        }
    }
}
