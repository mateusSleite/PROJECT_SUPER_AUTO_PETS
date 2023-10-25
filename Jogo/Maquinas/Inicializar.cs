using System;
using System.Collections.Generic;

public class Inicializar : Maquinas
{
    public Inicializar(Martelo martelos)
    {
        Martelo martelo = new Martelo();
        LojaBase.Add(martelo);
    }
}