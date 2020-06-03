using System;

public class Mat{
    public static double pi = 3.14;

    public static int dobro(int n ){
        return n * 2;
    }
}

public class Aula49 {
    public static void Main() {

            double vpi = Mat.pi;
            int num = 10;
            
            Console.WriteLine(Mat.dobro(num));
            Console.WriteLine(vpi);

    }
}