using System;


public class Galinha {
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha) {
            this.nomeGalinha = nomeGalinha;
            this.numOvo = 0;
    }

    public Ovo botar() {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }

}

public class Ovo {

    private int numOvo;
    private string minnhaGalinha;
    public Ovo(int numOvo, string minnhaGalinha) {
        this.numOvo = numOvo;
        this.minnhaGalinha = minnhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", this.numOvo, this.minnhaGalinha);
    }
    
}

public class Aula45 {
    public static void Main() {

        Galinha g1 = new Galinha("Judite");
        Galinha g2 = new Galinha("Benedita");
        Galinha g3 = new Galinha("Lucinda");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();

        g3.botar();
        g3.botar();


    }
}