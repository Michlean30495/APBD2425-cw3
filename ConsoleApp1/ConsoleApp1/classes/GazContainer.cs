using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class GazContainer : Container, IHazardNotifier
{
    private int cisnienie;
    private string gasName;
    public GazContainer(int height, double weight, int depth) 
        : base(height, weight, depth)
    {
        serialNumber = "KON-G-" + num;
    }

    public override void emptyLoad()
    {
        weightLoad = 0.05 * weightLoad;
        gasName = "";
    }

    public void Notify(string notification)
    {
        Console.WriteLine($"Niebezpieczna sytuacja: {notification}" + 
                          $" Numer kontenera: {serialNumber}");
    }
}