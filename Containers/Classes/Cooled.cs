namespace Classes;

public class Cooled(int height, int depth, int weight, int maximumMass, string expectedProduct, int temperature)
    : Container(height, depth, weight, maximumMass, expectedProduct)
{
    private int temperature = temperature;


    public override string ToString()
    {
        return $"{base.ToString()} Amount:{GetMass()} Complete Weight:{GetMaximumMass()} Temperature:{temperature}";
    }

    public int GetTemperature()
    {
        return temperature;
    }

    public void SetTemperature(int temperature)
    {
        this.temperature = temperature;
    }
}