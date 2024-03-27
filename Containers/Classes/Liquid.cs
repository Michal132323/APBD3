using Interface;
namespace Classes;


public class Liquid(int height, int depth, int weight, int maximumMass, string loadName, bool dangerousLoad)
    : Container(height, depth, weight, maximumMass,loadName), IHazardNotifier
{

    
    public void NotifyHazard()
    {
        Console.Write("Dangerous situation attempted on Liquid Container " + GetSerialNumber());
    }


    public override String ToString()
    {
        return $"{base.ToString()}, Amount:{GetMass()}, Complete Weight {GetMaximumMass()}";
    }
}