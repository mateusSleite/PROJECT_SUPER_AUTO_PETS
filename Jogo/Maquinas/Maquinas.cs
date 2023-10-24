public class Martelo : MaquinasAtb
{
    public Martelo()
    {
        this.Tier = 1;
        this.Nome = "Martelo";
        this.Ataque = 2;
        this.Vida = 3;
        this.Nivel = 1;
        this.Xp = 0;
    }
}

public class ChaveDeFenda : MaquinasAtb
{
    public ChaveDeFenda()
    {
        this.Tier = 1;
        this.Nome = "Chave de Fenda";
        this.Ataque = 2;
        this.Vida = 3;
        this.Nivel = 1;
        this.Xp = 0;
    }
}

public class Esteira : MaquinasAtb
{
    public Esteira()
    {
        this.Tier = 1;
        this.Nome = "Esteira";
        this.Ataque = 3;
        this.Vida = 1;
        this.Nivel = 1;
        this.Xp = 0;
    }
}