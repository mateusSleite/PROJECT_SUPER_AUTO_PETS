public class Maquinas
{
    public class Martelo  : MaquinasAtb
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

    public class ChaveDeFenda  : MaquinasAtb
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

    public class Esteira  : MaquinasAtb
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

    public class FuradeiraDeColuna  : MaquinasAtb
    {
        public FuradeiraDeColuna()
        {
            this.Tier = 2;
            this.Nome = "Furadeira de Coluna";
            this.Ataque = 3;
            this.Vida = 5;
            this.Nivel = 1;
            this.Xp = 0;
        }
    }

    public class FornoIndustrialAGas  : MaquinasAtb
    {
        public FornoIndustrialAGas()
        {
            this.Tier = 2;
            this.Nome = "Forno Industrial a Gas";
            this.Ataque = 1;
            this.Vida = 3;
            this.Nivel = 1;
            this.Xp = 0;
        }
    }

    public class RetificaPlana  : MaquinasAtb
    {
        public RetificaPlana()
        {
            this.Tier = 2;
            this.Nome = "Retifica Plana";
            this.Ataque = 4;
            this.Vida = 2;
            this.Nivel = 1;
            this.Xp = 0;
        }
    }
}