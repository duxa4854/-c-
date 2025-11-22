using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

public class Stopw
{
    public int Hours { get; private set; }
    public int Minutes { get; private set; }
    public int Seconds { get; private set; }
    public int Milliseconds { get; private set; }

    private readonly int tickStep;
    public Stopw (int tickStep = 15)
    {
        this.tickStep = tickStep;
    }
    public void Tick()
    {
        Milliseconds += tickStep;
        if (Milliseconds >= 1000)
        {
            Milliseconds = 0;
            Seconds++;
        }
        if (Seconds >= 60)
        {
            Seconds = 0;
            Minutes++;
        }
        if (Minutes >= 60)
        {
            Minutes = 0;
            Hours++;
        }
    }
    public void Reset()
    {
        Hours = Minutes = Seconds = Seconds = 0;
    }
    public string GetFormattedTime()
    {
        return $"{Hours:00}:{Minutes:00}:{Seconds:00}:{Milliseconds:00}";

    }
}

