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
		/*
			0 ≤ Speed < 50
			0 ≤ Distance < 100
			1 ≤ Road ≤ 100
			1 ≤ Gap ≤ 100
			1 ≤ Platform ≤ 100		
		*/
		
        int roadLength     = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int gapLength      = int.Parse(Console.ReadLine()); // the length of the gap.
        int platformLength = int.Parse(Console.ReadLine()); // the length of the landing platform.

        // game loop
        while (true)
        {
            int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int distance = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.

            Console.WriteLine(
                distance == roadLength - 1 ? "JUMP" :
                distance > roadLength - 1  ? "SLOW" :
                speed == gapLength + 1     ? "WAIT" :
                speed > gapLength + 1      ? "SLOW" :
                "SPEED");
        }
    }
}