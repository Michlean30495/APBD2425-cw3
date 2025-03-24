using ConsoleApp1.enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class FluidsContainer : Container, IHazardNotifier
{
    private LoadTypes type;
    private string fluidName;
    public FluidsContainer(int height, double weight, int depth, LoadTypes type)
    : base(height, weight, depth)
    {
        this.type = type;
        if (type.Equals(LoadTypes.FluidSafe))
        {
            maxLoad = height * depth * 0.9;
        } else if (type.Equals(LoadTypes.FluidUnsafe))
        {
            maxLoad = height * depth * 0.5;
        }
        serialNumber = "KON-L-" + num;
    }

    public void Notify(string notification)
    {
        Console.WriteLine($"Niebezpieczna sytuacja: {notification}" + 
                          $" Numer kontenera: {serialNumber}");
    }
    
    public override void load(double weightLoad, string load)
    {
        if (weightLoad > maxLoad)
        {
            Notify("Probujesz wykonac niebezpieczna operacje.");
            throw new OverfillException("Load overfill");
        }

        this.weightLoad = weightLoad;
        fluidName = load;
    }
}