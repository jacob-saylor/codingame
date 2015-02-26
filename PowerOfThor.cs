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
        string[] inputs = Console.ReadLine().Split(' ');
        Vector startingPoint = new Vector(int.Parse(inputs[2]), -int.Parse(inputs[3]));
        Vector endingPoint = new Vector(int.Parse(inputs[0]),-int.Parse(inputs[1]));

        // game loop
        while (true)
        {
            int E = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.

            string direction = GetDirection(startingPoint, endingPoint);
            Console.WriteLine(direction);
            updateStartingPoint(startingPoint, direction);
        }
    }
    
    static string GetDirection(Vector startingPoint, Vector endingPoint)
    {
        try
        {
            Console.Error.WriteLine("startingPoint... x: " + startingPoint.x + " y:" + startingPoint.y);
            Console.Error.WriteLine("endingPoint... x: " + endingPoint.x + " y:" + endingPoint.y);
            
            //if()
            
        }
        catch
        {
            return "S";
        }
    }
    
    static void updateStartingPoint(Vector startingPoint, string direction)
    {
        if(direction == "n") startingPoint.y--;
        //if d
    }
}

    class Vector
    {
        public int x {get;set;}
        public int y {get;set;}
    }
    
    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

enum Direction {E, NE, N, NW, W, SW, S, SE};
