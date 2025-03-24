namespace ConsoleApp1;

public class Container
{
    protected double weightLoad;
    private int height;
    private double weight;
    private int depth;
    protected string serialNumber;
    protected double maxLoad { get; set;}

    public static int num = 1;
    private string loadName;

    public Container(int height, double weight, int depth)
    {
        this.height = height;
        this.weight = weight;
        this.depth = depth;
        serialNumber = "KON-D-" + num;
        maxLoad = height * weight;
    }

    public virtual void emptyLoad()
    {
        weightLoad = 0;
        loadName = "";
    }

    public virtual void load(double weightLoad, string load)
    {
        if (weightLoad > maxLoad)
        {
            throw new OverfillException("Load overfill");
        }

        this.weightLoad = weightLoad;
        loadName = load;
    }

    public double getWeight()
    {
        return weightLoad + weight;
    }

    public string getSerialNumber()
    {
        return serialNumber;
    }

    public string toString()
    {
        return serialNumber + "," + loadName + "," + height + "," + depth + "," + weightLoad + "," + weight;
    }
}