using System;
using System.Collections.Generic;

namespace Aula{
    
}

public class Aula55 {
    public static void Main() {
            Dictionary <int , string> veiculos  = new Dictionary <int , string>();

            veiculos.Add(5, "Carro");
            veiculos.Add(10, "Avião");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "patinete");
            // veiculos.Clear();
            
            veiculos.Remove(20);
            veiculos[15] = "Bicicleta";

            int chave = 20;
            if(veiculos.ContainsKey(chave)) {
                    Console.WriteLine("A chave {0} esta na colecão", chave);
            } else {
                    Console.WriteLine("A chave {0} nao esta na colecão", chave);
            }

        string valor = "Bicicleta";

            if(veiculos.ContainsValue(valor)) {
                    Console.WriteLine("O valor {0} esta na colecão", valor);
            } else {
                    Console.WriteLine("O valor {0} nao esta na colecão", valor);
            }

            Dictionary <int, string>.ValueCollection valores = veiculos.Values;

            foreach(string v in valores) {
                Console.WriteLine(v);
            }


            Console.WriteLine("Tamanho do dictionary : {0}", veiculos.Count);
            
            
    }
}