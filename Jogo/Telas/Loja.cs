using System;
using System.Collections.Generic;

public class Loja
{
    public List<Maquinas> Lojinha = new List<Maquinas>();


    private Loja() { }

    private static Loja crr = null;
    public static Loja current => crr;

    private int Moedinha { get; set; }
    private AcaoComprar acaoComprar = null;

    public void Adicionar()
    {
        var random = new Random();
        int index = random.Next(LojaBase.Count);
        Lojinha.Add(maquina);
    }

    public void Comprar(MaquinasAtb[] maquinasParaCompra)
    {
        ArgsComprar args = new ArgsComprar();

        foreach (MaquinasAtb maquina in maquinasParaCompra)
        {
            args.Maquinas = maquina;

            // Aplicar ação de compra para cada máquina
            acaoComprar.Apply(args);

            // Aplicar sistema de subtração de moedas, se necessário

            // Adicionar a máquina comprada ao time
            Team.Add(maquina);
        }
    }


    public void Vender(Maquinas maquinas)
    {
        ArgsVender args = new ArgsVender();
        args.Maquinas = maquinas;
        args.Maquinas = this;

        acaoVender.Apply(args);

        //Aplicar sum de moedas caso ocorra a venda de uma maquina (nivel * 1)

        // Aplicar sistema de sum de moedas
        Team.Remove(maquinas); // remover maquina no time após a compra (precisa implementar o time)
    }

    public void Atualizar(Maquinas maquinas)
    {
        ArgsAtualizar args = new ArgsAtualizar();
        args.Maquinas = maquinas;
        args.Maquinas = this;

        acaoAtualizar.Apply(args);

        // Aplicar sistema de sub de moedas e atualizacao da loja
    }

    public class LojaBuilder
    {
        private Loja loja = new Loja();

        public Loja Build()
            => this.loja;

        public LojaBuilder SetFabrica(IFabricaAcoes fabrica)
        {
            loja.processoDemissao = fabrica.CriaProcessoDemissao();
            loja.processoPagamentoSalario = fabrica.CriaProcessoPagamentoSalario();
            loja.processoContratacao = fabrica.CriaProcessoContratacao();
            return this;
        }

        public LojaBuilder SetMoedinha(int moedinha)
        {
            loja.Moedinha = moedinha;
            return this;
        }

        public LojaBuilder AddMaquina(Maquinas maquinas)
        {
            //Gerar tres maquinas aleatorias

            return this;
        }
    }
}