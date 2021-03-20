using System;

public class Aula52 {
    public static void Main() {
            int n1, n2, res = 0;


            n1 = 10;
            n2 = 0;

            try{
                res = n1 / n2;
                Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
            } catch(Exception e){
                    Console.WriteLine("Erro {0}", e.Message);
            }
            
    }
}