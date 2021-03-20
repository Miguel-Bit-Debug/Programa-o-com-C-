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

    public int fat(int n) {
        int res;
        if(n <= 1) {
            res = 1;
        } else {
            res = n * fat(n - 1);
        }
        return res;
    }
    
}

public class Aula47 {
    public static void Main() {

        Calc calculadora = new Calc();

        var res = calculadora.fat(10);

        Console.WriteLine(res);

        

    }
}