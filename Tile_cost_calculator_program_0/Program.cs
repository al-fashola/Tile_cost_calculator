// See https://aka.ms/new-console-template for more information
using System;

namespace Tile_cost_calculator_program_0
{
    internal class Program
    {
        // public static double labour_cost;
        // public static double sq_ft;
        static void Main(string[] args)
        {
            //create constant variables for shapes
            const double PI = 3.1415926535897931;
            const double COST_PER_HOUR_LABOUR = 86.00;
            const double AVG_FLOORING = 20.00;
            
            //Create lists for shapes
            List<string> circles = new List<string>();
            List<string> rectangles = new List<string>();
            List<string> triangles = new List<string>();
                        
            //add values to variables
            circles.Add("circle");
            circles.Add("sphere");
            rectangles.Add("rectangle");
            rectangles.Add("square");
            triangles.Add("triangle");
            
            //User intructions and intro messages
            Console.WriteLine("Hello User, today you will be required to enter a few details to help you calculate your expected costs \n");
            
            Console.WriteLine("Please enter the cost per 1 unit of flooring:");
            double Cost_per_foot = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What shape would like this calculated for? (Please note, the only accepted options are as follows: Rectangle, Circle, Triangle)");
            string shape =  Console.ReadLine();
            shape = shape.ToLower();
            
            if (!circles.Contains(shape) & !triangles.Contains(shape) & !rectangles.Contains(shape))
            {
                Console.WriteLine("Shape not supported");
                return;
            }
            
            //Console.WriteLine(shape);
            
            //define calculation variables
            double width; 
            double sq_ft = 0;
            
            if (rectangles.Contains(shape))
            {
                double length;
                Console.WriteLine("Please enter the length:");
                length = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Please enter the width:");
                width = Convert.ToDouble(Console.ReadLine());
                sq_ft = length * width;
                
            }

            if (circles.Contains(shape))
            {
                double radius;
                Console.WriteLine("Please enter the radius:");
                radius = Convert.ToDouble(Console.ReadLine());
                sq_ft = (PI * Math.Pow(radius, 2)) ;
                
            }
            
            if (triangles.Contains(shape))
            {
                double height;
                Console.WriteLine("Please enter the height:");
                height = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Please enter the width:");
                width = Convert.ToDouble(Console.ReadLine());
                sq_ft = ((height * width) / 2);
           
            }
            
            double labour_cost = 0;
            double cost_per_sq_ft;
            
            cost_per_sq_ft = Math.Round((sq_ft * Cost_per_foot),2);
            labour_cost = Math.Round(((sq_ft / AVG_FLOORING) * COST_PER_HOUR_LABOUR), 2);
            double final_cost = Math.Round((labour_cost + cost_per_sq_ft), 2);
                
            Console.WriteLine($"The cost to cover this area is: ${cost_per_sq_ft}" );
            Console.WriteLine($"The labour cost is: ${labour_cost}");
            Console.WriteLine($"The total cost is: ${final_cost}" );
            

        }
    }
}