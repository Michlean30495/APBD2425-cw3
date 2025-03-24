using ConsoleApp1;
using ConsoleApp1.enums;


Container con1 = new Container(10, 1.4, 20);
FluidsContainer fcon = new FluidsContainer(20, 2.2, 20,
    LoadTypes.FluidSafe);
GazContainer gcon = new GazContainer(100, 1.4, 100);
CoolingContainer ccon = new CoolingContainer(12, 1.4,
    200,"nabial");
    
con1.load(1,"sprzet agd");
fcon.load(12, "mleko");
gcon.load(14, "hel");
ccon.load(14, "nabial", Products.Cheese);

Ship ship1 = new Ship(100, 6, 50, "ship1"); 
ship1.loadNewContainer(fcon);
ship1.loadNewContainer(gcon);
    
List<Container> containers = new List<Container>();
containers.Add(con1);
containers.Add(ccon);
    
ship1.loadNewContainer(containers);
    
ship1.deleteContainer(con1);
    
fcon.emptyLoad();
    
ship1.replaceContainer("KON-G-3", ccon);
    
Ship ship2 = new Ship(100, 6, 50, "ship2");
ship1.moveContainer(ship2,gcon);


ship1.toString();
Console.WriteLine(gcon.toString());
