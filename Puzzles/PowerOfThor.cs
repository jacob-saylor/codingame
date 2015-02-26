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
        Vector startingPoint = new Vector(int.Parse(inputs[2]), int.Parse(inputs[3]));
        Vector endingPoint = new Vector(int.Parse(inputs[0]), int.Parse(inputs[1]));

        // game loop
        while (true)
        {
            int E = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.

            string direction = GetDirection(startingPoint, endingPoint);
            startingPoint = updateStartingPoint(startingPoint, direction);
            
            Console.WriteLine(direction.ToUpper());
        }
    }
    
    static string GetDirection(Vector startingPoint, Vector endingPoint)
    {
        try
        {
            Console.Error.WriteLine("startingPoint... x: " + startingPoint.x + " y:" + startingPoint.y);
            Console.Error.WriteLine("endingPoint... x: " + endingPoint.x + " y:" + endingPoint.y);
            
            if (startingPoint.x < endingPoint.x && startingPoint.y <endingPoint.y)
            {
                return "se";
            }
            else if (startingPoint.x > endingPoint.x && startingPoint.y < endingPoint.y)
            {
                return "sw";
            }
            else if (startingPoint.x < endingPoint.x && startingPoint.y > endingPoint.y)
            {
                return "ne";
            }
            else if (startingPoint.x > endingPoint.x && startingPoint.y > endingPoint.y)
            {
                return "nw";
            }
            else 
            {
                if (startingPoint.x < endingPoint.x)
                {
                    return "e";
                }
                else if (startingPoint.x > endingPoint.x)
                {
                    return "w";
                }
                if (startingPoint.y < endingPoint.y)
                {
                    return "s";
                }
                else if (startingPoint.y > endingPoint.y)
                {
                    return "n";
                }
                return "s";
            }
        }
        catch
        {
            return "s";
        }
    }
    
    static Vector updateStartingPoint(Vector startingPoint, string direction)
    {
        Vector updatedVector = startingPoint;
        Console.Error.WriteLine("direction: " + direction);
        
        switch (direction)
        {
            case "e" :
            	updatedVector.x++;
            	break;
            case "ne":
            	updatedVector.x++;
            	updatedVector.y--;
            	break;
            case "n" :
            	updatedVector.y--;  
            	break;
            case "nw":
                updatedVector.x--;
            	updatedVector.y--;
            	break;
            case "w" :
            	updatedVector.x--;
            	break;
            case "sw":
            	updatedVector.x--; 
            	updatedVector.y++;
            	break;
            case "s" : 
            	updatedVector.y++;
            	break;
            case "se":
            	updatedVector.x++; 
            	updatedVector.y++;
            	break;
        }
        
        return updatedVector;
    }
}

class Vector
{
    public int x {get;set;}
    public int y {get;set;}

    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}