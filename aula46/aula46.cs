using System;


public class Calc{
    public int soma(params int[]n) {
        int s = 0;
        for(int i  = 0; i < n.Length; i++) {
            s += n[i];
        }
        return s;
    }

    public double soma(params double[]n) {
        double s = 0;
        for(int i = 0; i < n.Length; i++) {
            s += n[i];
        }
        return s;
    }
    
}

public class Aula46 {
    public static void Main() {

        Calc calculadora = new Calc();

        var res = calculadora.soma(10, 5, 8, 8, 5, 6, 9, 7, 10 ,10 ,20, 5, 70, 90,80 ,70, 60, 9087);
        var res2 = calculadora.soma(5.0, 4.8, 7.8);

        Console.WriteLine(res + "\n" + res2);

        

    }
}