using System;
using System.Collections.Generic;

public class Loja
{
    private Loja() { }

    private static Loja crr = null;
    public static Loja currente => crr;

    private int Moedinha { get; set; }
    private AcaoComprar acaoComprar = null;

    public void Comprar(Maquinas maquinas)
    {
        ArgsComprar args = new ArgsComprar();
        args.Maquinas = maquinas;
        args.Maquinas = this;

        acaoComprar.Apply(args);
        // Aplicar sistema de sub de moedas
        Team.Add(maquinas); // adicionar maquina no time após a compra (precisa implementar o time)
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

        public LojaBuilder SetNome(string nome)
        {
            loja.Nome = nome;
            return this;
        }

        public LojaBuilder SetFabrica(IFabricaProcessos fabrica)
        {
            loja.processoDemissao = fabrica.CriaProcessoDemissao();
            loja.processoPagamentoSalario = fabrica.CriaProcessoPagamentoSalario();
            loja.processoContratacao = fabrica.CriaProcessoContratacao();
            return this;
        }
        
        public LojaBuilder SetCapitalInicial(decimal dinheiro)
        {
            loja.Dinheiro = dinheiro;
            return this;
        }

        public LojaBuilder AddEmpregado(string nome, decimal salario)
        {
            Loja loja = new Loja();
            loja.Nome = nome;
            loja.Salario = salario;
            loja.Contratar(loja);
            return this;
        }
    }
}