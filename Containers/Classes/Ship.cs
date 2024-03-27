namespace Classes;

using Exception;

public class Ship : OverfillException
{
    private List<Container> containers;
    private int speed;
    private int maxContainerCount;
    private int maxWeight;
    private int currentWeight;

    public Ship(int speed, int maxContainerCount, int maxWeight)
    {
        this.speed = speed;
        this.maxContainerCount = maxContainerCount;
        this.maxWeight = maxWeight;
        containers = new List<Container>();
    }

    public void NewGasContainer(int height, int depth, int weight, int maximumMass, string loadName, bool dangerousLoad)
    {
        LimitTest();
        LimitTest(weight);
        Gas container = new Gas(height, depth, weight, maximumMass, loadName, dangerousLoad);
        containers.Add(container);
    }

    public void NewLiquidContainer(int height, int depth, int weight, int maximumMass, string loadName,
        bool dangerousLoad)
    {
        LimitTest();
        LimitTest(weight);
        Liquid container = new Liquid(height, depth, weight, maximumMass, loadName, dangerousLoad);
        containers.Add(container);
    }

    public void NewCooledContainer(int height, int depth, int weight, int maximumMass, string expectedLoad,
        int temperature, bool dangerousLoad)
    {
        LimitTest();
        LimitTest(weight);
        Cooled container = new Cooled(height, depth, weight, maximumMass, expectedLoad, temperature);
        containers.Add(container);
    }

    public void AddContainer(Container container)
    {
        LimitTest();
        LimitTest(container.GetFullMass());
        containers.Add(container);
    }

    public void LoadContainers(List<Container> newContainers)
    {
        for (int i = 0; i < newContainers.Count; i++)
        {
            containers.Add(newContainers[i]);
        }
    }

    public void tradeContainer(Container container, Ship ship)
    {
        if (!containers.Contains(container)) return;
        containers.Remove(container);
        ship.AddContainer(container);
    }

    public void RemoveContainer(Container container)
    {
        if (!containers.Contains(container)) return;
        containers.Remove(container);
    }

    public void ReplaceContainer(Container added, int number)
    {
        var container = containers.Find(container => container.GetCount() == number);
        containers.Remove(container);
        LimitTest(added.GetFullMass());
        containers.Add(added);
    }

    private void CalculateWeight()
    {
        int weight = 0;
        for (int i = 0; i < containers.Count; i++)
        {
            weight += containers[i].GetFullMass();
        }

        currentWeight = weight;
    }

    private void LimitTest(int mass)
    {
        if (currentWeight + mass > maxWeight)
        {
            throw new OverfillException("Ship is already full");
        }
    }

    private void LimitTest()
    {
        if (containers.Count >= maxContainerCount)
        {
            throw new OverfillException("Ship is already full");
        }
    }

    public override string ToString()
    {
        return "Ship sailing at speeds of " + speed + " with maximum storage of " + maxContainerCount +
               " and max weight of " + maxWeight + "the currently " +
               "held containers are :" + containers;
    }
}