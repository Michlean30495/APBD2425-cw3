namespace ConsoleApp1;

public class Ship
{
    private List<Container> containers = new List<Container>();
    private int speed;
    private int maxContainers;
    private double maxLoadCapacity;
    private double currentLoadCapacity;
    private string name;
    
    public Ship(int speed, int maxContainers, int maxLoadCapacity, string name)
    {
        this.speed = speed;
        this.maxContainers = maxContainers;
        this.maxLoadCapacity = maxLoadCapacity;
        this.name = name;
    }

    public void loadNewContainer(Container container)
    {
        if (currentLoadCapacity + container.getWeight() > maxLoadCapacity)
        {
            throw new Exception("Can't load due to weight");
        }

        if (containers.Count >= maxContainers)
        {
            throw new Exception("Can't load due to amount of containers");
        }
        
        containers.Add(container);
        updateCurrentLoadCapacity(container.getWeight());
    }
    
    public void loadNewContainer(List<Container> con)
    {
        if (currentLoadCapacity + getWeightOfList(con) >= maxLoadCapacity)
        {
            throw new Exception("Can't load due to weight");
        }

        if (containers.Count + con.Count >= maxContainers)
        {
            throw new Exception("Can't load due to amount of containers");
        }
        
        foreach (Container container in con)
            containers.Add(container);
        updateCurrentLoadCapacity(getWeightOfList(con));
    }


    private void updateCurrentLoadCapacity(double w)
    {
        currentLoadCapacity += w;
    }


    public double getWeightOfList(List<Container> conts)
    {
        double weight = 0;
        foreach (Container con in conts)
        {
            weight += con.getWeight();
        }
        return weight;
    }

    public void deleteContainer(Container cont)
    {
        containers.Remove(cont);
        updateCurrentLoadCapacity(-cont.getWeight());
    }

    public void replaceContainer(string serialNum, Container contIn)
    {
        foreach (Container cont in containers)
        {
            if (cont.getSerialNumber() == serialNum)
            {
                containers.Remove(cont);
                updateCurrentLoadCapacity(-cont.getWeight());
            }
        }

        
        containers.Add(contIn);
        updateCurrentLoadCapacity(contIn.getWeight());
    }

    public void moveContainer(Ship ship, Container contToMove)
    {
        if (ship.currentLoadCapacity + contToMove.getWeight() > maxLoadCapacity)
        {
            throw new Exception("Can't move due to weight");
        }

        if (ship.containers.Count >= maxContainers)
        {
            throw new Exception("Can't move due to amount of containers");
        }
        containers.Remove(contToMove);
        updateCurrentLoadCapacity(contToMove.getWeight());
        ship.containers.Add(contToMove);
        ship.updateCurrentLoadCapacity(contToMove.getWeight());
    }

    public void toString()
    {
       Console.Write(name);
       Console.Write(", [");
       
       foreach (Container cont in containers)
       {
           Console.Write(cont.toString());
           Console.Write(" ; ");
       }
       Console.Write("]");
       Console.WriteLine();
    }
}