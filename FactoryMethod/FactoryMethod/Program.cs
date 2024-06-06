using FactoryMethod;
using System.Net.WebSockets;
using System.Text;


List<IFactory> factories = new List<IFactory>()
{
    new Figure1Factory(),
    new Figure2Factory(),
    new Figure3Factory(),
    new Figure4Factory(),
    new Figure5Factory(),
    new Figure6Factory()
};

Figures figure = null;

while (true)
{
    Random randomFactory = new Random();
    int number = randomFactory.Next(1,factories.Count+1);

    Random randomColor = new Random();
    int color=randomColor.Next(0,3);

    if(color == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if(color == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (color == 2)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }

    if (number == 1)
    {
        figure = factories[0].Create();
        figure.ShowFigure();
    }
    else if (number == 2)
    {
        figure = factories[1].Create();
        figure.ShowFigure();
    }
    else if (number == 3)
    {
        figure = factories[2].Create();
        figure.ShowFigure();
    }
    else if (number == 4)
    {
        figure = factories[3].Create();
        figure.ShowFigure();
    }
    else if (number == 5)
    {
        figure = factories[4].Create();
        figure.ShowFigure();
    }
    else if (number == 6)
    {
        figure = factories[5].Create();
        figure.ShowFigure();
    }
    Console.WriteLine();
    Thread.Sleep(800);
}