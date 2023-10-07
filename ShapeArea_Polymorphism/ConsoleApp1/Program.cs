using ShapeArea.Features.AreaCalculator;

Console.WriteLine("Shape Area Program started!");

var result = await AreaCalculator.Execute();

Console.WriteLine("The shape's area is: {0:n2}", result);