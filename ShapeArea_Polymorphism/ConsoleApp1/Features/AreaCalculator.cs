using ShapeArea.ShapeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea.Features.AreaCalculator
{
    static class AreaCalculator
    {
        public static Task<double> Execute()
        {
            var totalArea = 0D; // Do not modify!
            BaseShape shape; // Do not modify!

            // === + Add your code from here + === //

            double choices, height, width, radius;

             Menu();

                Console.WriteLine("Select Choices");
                choices = Convert.ToInt32(Console.ReadLine());

                switch (choices)
                {
                    case 1:
                        Console.WriteLine("Triangle: ");
                        BaseShape triangle = new triangle();

                        Console.WriteLine("Height: ");
                        height = Convert.ToDouble (Console.ReadLine());
                   


                        Console.WriteLine("Width: ");
                        width = Convert.ToDouble(Console.ReadLine());
                   

                    shape = new triangle
                        {
                            Height= height,
                            Width = width,
                        };

                        break;

                    case 2:

                        Console.WriteLine("Square");
                        BaseShape square= new square();

                        Console.WriteLine("Height: ");
                        height = Convert.ToDouble(Console.ReadLine());
          


                        Console.WriteLine("Width: ");
                        width = Convert.ToDouble(Console.ReadLine());
           

                        shape = new square
                        {
                            Height = height,
                            Width = width,
                        };

                        break;

                   case 3:

                        Console.WriteLine("Circle");


                        Console.WriteLine("Radius: ");
                        radius = Convert.ToDouble(Console.ReadLine());

                    shape = new Circle
                        {
                            radius = radius,
                        };
                                           
                        break;

                default:
                    shape = new triangle
                    {
                        Height = 1,
                        Width = 1
                    };

                        break;

                }
            
            // === - Your code ends here - === //

       totalArea = shape.GetArea(); // Do not modify! Uncomment once your code is done.

          return Task.FromResult(totalArea); // Do not modify!
        }
       
        static void Menu()
        {
            Console.WriteLine("Select Shape Type: ");
            Console.WriteLine("1 = Triangle ");
            Console.WriteLine("2 = Square");
            Console.WriteLine("3 = Circle ");
            Console.WriteLine("Type here : ");

        }

    }

    
}
    

