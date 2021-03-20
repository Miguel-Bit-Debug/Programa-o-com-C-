using System;
using System.Collections.Generic;

public class Aula58 {
    public static void Main(){

        List <string> carros = new List<string>();
        string[] carros2 = new string[10];


        carros.Add("Ferrari");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        //carros.Clear();

        if(carros.Contains("Argos")) {
            Console.WriteLine("Está na lista");
        } else {
            Console.WriteLine("Não encontrado");
        }

        // carros2.AddRange(carros);

        carros.CopyTo(carros2, 2);

        carros.Insert(1, "Cruze");
        carros.Remove("Argo");
        carros.RemoveAt(0);

        carros.Reverse();
        carros.Sort();

        int tamanho = carros.Count;
        Console.WriteLine("Tamanho {0}", tamanho);
        carros.Capacity = 15;
        int cap = carros.Capacity;
        Console.WriteLine("Capacidade {0}", cap);

        
        foreach(string carro in carros) {
            Console.WriteLine("Carro: {0}", carro);
        }

        string c = "HRV";
        int pos = 0;
        pos = carros.IndexOf(c);
        int posicao = carros.LastIndexOf("HRV");


        Console.WriteLine("Carro : {0} está na posição {1}", c, pos);
        Console.WriteLine("Ultimo HRV está na posição {0}", posicao);


    }
}