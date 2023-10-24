public class ArgumentosAcoes
{
    private static ArgumentosAcoes empty = new ArgumentosAcoes();
    public static ArgumentosAcoes Empty => empty;
}

public class ArgsSoquinho : ArgumentosAcoes
{
    public Maquinas Maquinas { get; set; }
}

public class ArgsEvoluiu : ArgumentosAcoes
{
    public Maquinas Maquinas { get; set; }
}

public class ArgsComprar : ArgumentosAcoes
{
    public Maquinas Maquinas { get; set; }
}

public class ArgsVender : ArgumentosAcoes
{
    public Maquinas Maquinas { get; set; }
}

public class ArgsAtualizar: ArgumentosAcoes
{
    public Maquinas Maquinas { get; set; }
}