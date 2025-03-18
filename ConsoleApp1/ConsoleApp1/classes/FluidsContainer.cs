using ConsoleApp1.enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class FluidsContainer : Container, IHazardNotifier
{
    private LoadTypes type;
    public FluidsContainer(int height, double weight, int depth, LoadTypes type)
    : base(height, weight, depth, "KON-L-" + Container.num)
    {
        this.type = type;
        if (type.Equals(LoadTypes.FluidSafe))
        {
            maxLoad = height * depth * 0.9;
        } else if (type.Equals(LoadTypes.FluidUnsafe))
        {
            maxLoad = height * depth * 0.5;
        }
    }

    public void Notify(string notification)
    {
        Console.WriteLine($"Niebezpieczna sytuacja: {notification}");
    }
}