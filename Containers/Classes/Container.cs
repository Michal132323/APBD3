
namespace Classes;

public class Container
{
    private static int counter = 0;
    private int mass = 0;
    private int maximumMass;
    private int height;
    private int depth;
    private int weight;
    private string serialNumber;
    private int count;
    private string loadName;

    protected Container(int height, int depth, int weight, int maximumMass,string loadName)
    {
        this.maximumMass = maximumMass;
        this.weight = weight;
        this.height = height;
        this.depth = depth;
        this.weight = 0;
        this.loadName = loadName;
        counter++;
        count = counter;
        string type = GetType().Name;
        serialNumber= "KON-"+type[0]+"-"+count;
    }
    private void AddLoad(string name, int amount)
    {
        loadName = name;
        mass = amount;
    }
    private void AddLoad(int amount)
    {
        mass += amount;
    }

    private void unload()
    {
        loadName = null;
        mass = 0;
    }
    public int GetMass()
    {
        return mass;
    }

    public int GetCount()
    {
        return count;
    }
    public string GetSerialNumber()
    {
        return serialNumber;
    }

    public int GetMaximumMass()
    {
        return maximumMass;
    }

    public int GetHeight()
    {
        return height;
    }

    public int GetDepth()
    {
        return depth;
    }

    public int GetWeight()
    {
        return weight;
    }
    public string GetLoadName()
    {
        return loadName;
    }
    public int GetFullMass()
    {
        return mass+weight;
    }
    
    public void SetMass(int mass)
    {
        this.mass = mass;
    }

    public void SetMaximumMass(int maximumMass)
    {
        this.maximumMass = maximumMass;
    }

    public void SetHeight(int height)
    {
        this.height = height;
    }

    public void SetDepth(int depth)
    {
        this.depth = depth;
    }

    public void SetWeight(int weight)
    {
        this.weight = weight;
    }

    public override string ToString()
    {
        return "["+GetType().Name+"]"+"Serial Number"+serialNumber+" Height:"+ height+" Depth:"+ depth +" Weight:"+ weight+" Capacity:" +maximumMass + "Load:"+GetLoadName();
    }
}