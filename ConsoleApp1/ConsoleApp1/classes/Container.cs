namespace ConsoleApp1;

public class Container
{
    private double weightLoad;
    private int height;
    private double weight;
    private int depth;
    private string serialNumber;
    protected double maxLoad { get; set;}

    public static int num = 1;

    public Container(int height, double weight, int depth,
        string serialNumber)
    {
        this.height = height;
        this.weight = weight;
        this.depth = depth;
        this.serialNumber = serialNumber;
    }

    public void emptyLoad()
    {
        weightLoad = 0;
    }

    public void load(double weightLoad)
    {
        if (weightLoad > maxLoad)
        {
            throw new OverfillException("Load overfill");
        }

        this.weightLoad = weightLoad;
    }
}