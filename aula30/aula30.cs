using System;

public class Jogador {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador() {
            energia = 100;
            vivo = true;
            nome = "Jogador";
        }
        public Jogador(string n) {
            energia = 100;
            vivo = true;
            nome = n    ;
        }
        public Jogador(string n, int e ) {
            nome = n;
            energia = e;
            vivo = true;
        }

        public Jogador(string n, int e , bool v) {
            nome = n;
            energia = e;
            vivo = v;
        }

        public void Info() {
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}", energia);
            Console.WriteLine("Estado jogador: {0}\n", vivo);

        }

}

class Aula30 {
    static void Main() {

        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Giovanna");
        Jogador j3 = new Jogador("Miguel", 100);    
        Jogador j4 = new Jogador("Benegundesfirno", 0, false);

            j1.Info();
            j2.Info();
            j3.Info();
            j4.Info();

    }
}