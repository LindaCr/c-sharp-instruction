using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingCollections
{
    class Bowling
    {
        Random rand = new Random();


        List<int> game = new List<int>();

        //changed method to random to skip entering data one frame at a time
       // public int Bowl()
      //  {
          //  for (var idx= 1; idx<=10; idx++)
          //  {
          //      Console.WriteLine($"Enter score for frame {idx}: ");
          //      var score = Convert.ToInt32(Console.ReadLine());
          //      game.Add(score);
          //  }
         //   var total = 0;
         //   foreach(var score in game)
        //    {
         //       total += score;
        //    }
        //    return total;
       // }

        public int Bowl()
        {
            for (var idx = 1; idx <= 10; idx++)
            {
                Console.WriteLine($"Enter score for frame {idx}: ");
                var score = rand.Next(31);
                game.Add(score);
            }
            var total = 0;
            foreach (var score in game)
            {
                total += score;
            }
            return total;
        }




    }
}
