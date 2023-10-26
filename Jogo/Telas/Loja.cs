using System;
using System.Collections.Generic;
using System.Linq;

public class Loja
{
    public List<Type> TodasMaquinas { get; set; } = new List<Type>
    {
        typeof(Martelo),
        typeof(ChaveDeFenda),
        typeof(Esteira),
        typeof(FuradeiraDeColuna),
        typeof(FornoIndustrialAGas),
        typeof(RetificaPlana)
    };

    public List<MaquinasAtb> Lojinha = new List<MaquinasAtb>();

    private PlayerTeam playerTeam = new PlayerTeam();

    private Loja() { }

    private static Loja crr = null;
    public static Loja current => crr;

    private int Moedinha { get; set; }
    private AcaoComprar acaoComprar = null;
    private AcaoVender acaoVender = null;
    private AcaoAtualizar acaoAtualizar = null;

    public void Comprar(MaquinasAtb maquinaParaCompra)
    {
        ArgsComprar args = new ArgsComprar();
        args.Maquinas = maquinaParaCompra;
        
        if (Moedinha < 3)
        {
            Console.WriteLine("Moedas insuficientes!");
            return;
        }

        acaoComprar.Apply(args);
        Moedinha -= 3;
        playerTeam.AddMachine(maquinaParaCompra);
    }

    public void Vender(MaquinasAtb maquinas)
    {
        ArgsVender args = new ArgsVender();
        args.Maquinas = maquinas;

        acaoVender.Apply(args);
        Moedinha += maquinas.Nivel;
        playerTeam.RemoveMachine(maquinas);
    }

    public void Atualizar()
    {
        var maquinasSorteadas = SortearTresMaquinasAleatorias();
        var builder = GetBuilder();

        foreach(var maquina in maquinasSorteadas)
        {
            builder.AddMaquina(maquina);
        }

        Loja novaLoja = builder.Build();
        crr = novaLoja;
    }

    private List<MaquinasAtb> SortearTresMaquinasAleatorias()
    {
        var random = new Random();
        var maquinasSorteadas = new List<MaquinasAtb>();

        for (int i = 0; i < 3; i++)
        {
            Type maquinaType;
            do
            {
                maquinaType = TodasMaquinas[random.Next(TodasMaquinas.Count)];
            } while (maquinasSorteadas.Any(m => m.GetType() == maquinaType));

            var maquina = (MaquinasAtb)Activator.CreateInstance(maquinaType);
            maquinasSorteadas.Add(maquina);
        }

        return maquinasSorteadas;
    }

    public class LojaBuilder
    {
        private Loja loja = new Loja();

        public Loja Build()
            => this.loja;

        public LojaBuilder SetFabrica(IFabricaAcoes acao)
        {
            loja.acaoComprar = acao.CriarComprar();
            loja.acaoVender = acao.CriarVender();
            loja.acaoAtualizar = acao.CriarAtualizar();
            return this;
        }

        public LojaBuilder SetMoedinha(int moedinha)
        {
            loja.Moedinha = moedinha;
            return this;
        }

        public LojaBuilder AddMaquina(MaquinasAtb maquinas)
        {
            loja.Lojinha.Add(maquinas);
            return this;
        }
    }

    public static LojaBuilder GetBuilder()
    {
        return new LojaBuilder();
    }
}
