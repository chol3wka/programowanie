using System.Net.NetworkInformation;

public class zadanie6
{
    public static void Main(string[] args) 
    {
       float a,b,c;
       float delta;
       float x0,x1,x2;

        Console.WriteLine("Podaj wartość a.");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość b.");
        b = float.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wartość c.");
        c = float.Parse(Console.ReadLine());

    if(a==0.0){
        Console.WriteLine("To nie jest równanie kwadratowe!");
    }else{
        delta = (float)Math.Pow(b,2)-(4*a*c);
        if(delta<0.0){
            Console.WriteLine("Brak rozwiązań!");
        }else if(delta==0.0){
            x0 =(-b)/(2*a);
            Console.WriteLine("x0= " + x0);
        }else{
            x1=(float)((-b)-Math.Sqrt(delta)/(2*a));
            x2=(float)((-b)+Math.Sqrt(delta)/(2*a));
            Console.WriteLine("x1= "+ x1);
            Console.WriteLine("x2= "+ x2);
        }
    }
}
}