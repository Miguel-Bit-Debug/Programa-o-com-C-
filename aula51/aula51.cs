using System;

public class Aula51 {
    public static void Main(string[] args) {

        int res = 0;
        

        if(args.Length > 0) {
            Console.WriteLine("Qtde de argumentos {0}", args.Length);
            foreach(string arg in args) {
                res += int.Parse(arg);
            }
            // for(int i = 0; i < args.Length; i++){
                // res += int.Parse(args[i]);
            // }
            Console.WriteLine("Soma {0}", res);
        } else {
            Console.WriteLine("Não foram passados argumentos");
        }

    }
}