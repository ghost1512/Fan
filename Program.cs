using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Create two Fan objects
        Fan fan1 = new Fan();
        fan1.Speed = fan1.FAST;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        fan1.On = true;

        Fan fan2 = new Fan();
        fan2.Speed = fan2.MEDIUM;
        fan2.Radius = 5;
        fan2.Color = "blue";
        fan2.On = false;

        // Display the state of the fans
        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());
    }
}

public class Fan
{
    public int SLOW = 1;
    public int MEDIUM = 2;
    public int FAST = 3;

    private int speed;
    private bool on;
    private double radius;
    private string color;

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public bool On
    {
        get { return on; }
        set { on = value; }
    }
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Fan()
    {
        this.speed = SLOW;
        this.on = false;
        this.radius = 0;
        this.color = "blue";
    }
    public override string ToString()
    {
        if (on)
        {
            return $"Fan is on: Speed={Speed}, Color={Color}, Radius={Radius}";
        }
        else
        {
            return $"Fan is off: Color={Color}, Radius={Radius}";
        }
    }
}

