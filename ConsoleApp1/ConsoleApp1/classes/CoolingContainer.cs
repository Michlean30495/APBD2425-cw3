using ConsoleApp1.enums;

namespace ConsoleApp1;

public class CoolingContainer : Container
{
    private string productType;
    private int tempOfCont;
    private List<Products> products = new List<Products>();
    
    public CoolingContainer(int height, double weight, int depth, string productType) 
        : base(height, weight, depth)
    {
        this.productType = productType;
        serialNumber = "KON-C-" + num;
    }

    public void load(double toLoad, string productType, Products product)
    {
        if (toLoad > maxLoad)
        {
            throw new OverfillException("Load overfill");
        }

        if (!productType.Equals(this.productType))
        {
            throw new Exception("Invalid product");
        }

        if ((int)product < tempOfCont)
        {
            throw new Exception("Invalid temperature");
        }
        
        weightLoad = toLoad;
        products.Add(product);
    }

    public override void emptyLoad()
    {
        weightLoad = 0;
        products.Clear();
    }
}