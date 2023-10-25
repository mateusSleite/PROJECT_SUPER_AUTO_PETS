public class ArgumentosAcoes
{
    private static ArgumentosAcoes empty = new ArgumentosAcoes();
    public static ArgumentosAcoes Empty => empty;
}

public class ArgsSoquinho : ArgumentosAcoes
{
    public MaquinasAtb  Maquinas { get; set; }
}

public class ArgsEvoluiu : ArgumentosAcoes
{
    public MaquinasAtb  Maquinas { get; set; }
}

public class ArgsComprar : ArgumentosAcoes
{
    public MaquinasAtb  Maquinas { get; set; }
}

public class ArgsVender : ArgumentosAcoes
{
    public MaquinasAtb  Maquinas { get; set; }
}

public class ArgsAtualizar: ArgumentosAcoes
{
    public MaquinasAtb  Maquinas { get; set; }
}