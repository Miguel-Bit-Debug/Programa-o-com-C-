using System;
using System.Collections.Generic;

public class Aula56 {
    public static void Main() {

        LinkedList <string> transp = new LinkedList<string>();

         transp.AddFirst("Carro");
         transp.AddFirst("Avião");
         transp.AddFirst("Navio");
         transp.AddFirst("Motocicleta");
         transp.AddLast("Bicicleta");
         LinkedListNode<string> no ;
         no = transp.FindLast("Navio").Next;
         transp.AddAfter(no, "Patinete");
         transp.AddBefore(no, "Skate");

        //  transp.Clear();

        if(transp.Find("Carro") == null){
            Console.WriteLine("Não encontrado");
        } else {
            Console.WriteLine("Elemento encontrado");
        }

        // transp.Remove("Navio"); //Remove na posicao indicada
        // transp.RemoveFirst(); remove primeiro   
        // transp.RemoveLast(); remove ultimo

        foreach(string t in transp) {
            Console.WriteLine("Transporte: {0}", t);
        }
    }
}
