using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        // game loop
        while (true)
        {
            List<int> mountainHeight = new List<int>();
            int nearestThreat = 0;
            string[] inputs = Console.ReadLine().Split(' ');
            
            int distance = int.Parse(inputs[0]); 
            int altitude = int.Parse(inputs[1]);
            
            for (int i = 0; i < 8; i++)
            {
                int MH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
                mountainHeight.Add(MH);
            }
            
            var highestMountain = mountainHeight.OrderByDescending(h => h).FirstOrDefault();
            nearestThreat = mountainHeight.IndexOf(highestMountain);
            
            // either:  FIRE (ship is firing its phase cannons) or HOLD (ship is not firing).
            Console.WriteLine(distance == nearestThreat ? "FIRE" : "HOLD");
        }
    }
}
