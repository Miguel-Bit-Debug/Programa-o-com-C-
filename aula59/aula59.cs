using System;
using System.Collections.Generic;

public class Aula59 {
    public static void Main() {
        // string[] v = {"Carro", "Moto", "Navio", "Avião"};
        Queue <string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro"); //Adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = "Avião";

        if(veiculos.Contains(v)){
            Console.WriteLine("Veiculo {0} encontrado", v);
        } else {
            Console.WriteLine("Veiculo {0} não esta na fila", v);
        }
        // Console.WriteLine("Primeiro veiculo {0}", veiculos.Dequeue());
        // Console.WriteLine("Primeiro veiculo {0}", veiculos.Peek());

        foreach(string v in veiculos) {
            v=veiculos.Dequeue();
            Console.WriteLine("Veiculo removido {0}", v);
        }
        Console.WriteLine("Tamanho da fila {0}", veiculos.Count);

        


    }
}