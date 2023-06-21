// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double userCoordinates(int xA, int yA, int zA , int xB ,int yB , int zB){
    // System.Console.WriteLine("enter point A x coordinate");
    // int xA =  Convert.ToInt32(Console.ReadLine());  
    // System.Console.WriteLine("enter point A y coordinate");
    // int yA =  Convert.ToInt32(Console.ReadLine()); 
    // System.Console.WriteLine("enter point A z coordinate");
    // int zA =  Convert.ToInt32(Console.ReadLine()); 

    // System.Console.WriteLine("enter point B x coordinate");
    // int xB =  Convert.ToInt32(Console.ReadLine());  
    // System.Console.WriteLine("enter point B y coordinate");
    // int yB =  Convert.ToInt32(Console.ReadLine()); 
    // System.Console.WriteLine("enter point B z coordinate");
    // int zB =  Convert.ToInt32(Console.ReadLine()); 

    int z = zB - zA;
    int y = yB - yA;
    int x = xB - xA;

    System.Console.WriteLine( Math.Sqrt((x * x) + (y * y) + (z * z)));

    double result = Math.Sqrt((x * x) + (y * y) + (z * z));
    return result;
}

userCoordinates(3,6,8,2,1,-7);
