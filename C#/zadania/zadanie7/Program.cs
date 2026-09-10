using System.Net.NetworkInformation;

public class zadanie7
{
    public static void Main(string[] args) 
    {
       float a,b,c,d,e,f;
       float w,x,y;

        Console.WriteLine("Podaj wartość a.");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość b.");
        b = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość c.");
        c = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość d.");
        d = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość e.");
        e = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość f.");
        f = float.Parse(Console.ReadLine());

    w = (a*e)-(d*b);
    if(w==0.0){
        Console.WriteLine("Układ nie ma rozwiązania!");
    }else{
        x=(float)((c*e)-(b*f))/w;
        y=(float)((a*f)-(c*d))/w;
        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);
    }
}
}