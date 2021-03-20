using System;
using System.Collections.Generic;

public class Aula57 {
    public static void Main(){

        List <string> carros = new List<string>();
        string[] carros2 = new string[10];


        carros.Add("Ferrari");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros.Clear();

        if(carros.Contains("Argos")) {
            Console.WriteLine("Está na lista");
        } else {
            Console.WriteLine("Não encontrado");
        }

        // carros2.AddRange(carros);

        carros.CopyTo(carros2, 2);

        foreach(string carro in carros) {
            Console.WriteLine("Carro: {0}", carro);
        }

        string c = "HRV";
        int pos = 0;
        pos = carros.IndexOf(c);

        Console.WriteLine("Carro : {0} está na posição {1}", c, pos);

    }
}