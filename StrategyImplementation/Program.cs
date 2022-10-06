using FigureCalculation.Figures;
using FigureCalculation.Strategy;

FigureStrategy strategy = new FigureStrategy();
Console.WriteLine("Strategy is set to Circle with radius 5");
strategy.SetFigureStrategy(new Circle(5));
Console.WriteLine(strategy.CalculateSquare());

Console.WriteLine();

Console.WriteLine("Strategy is set to Triangle with the sides: 3, 4, 5");
strategy.SetFigureStrategy(new Triangle(3, 4, 5));
Console.WriteLine(strategy.CalculateSquare());

Console.ReadLine();
