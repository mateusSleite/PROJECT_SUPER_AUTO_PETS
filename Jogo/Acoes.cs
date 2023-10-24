public abstract class Acoes
{
    public abstract string Title { get; }
}

public abstract class AcaoSoquinho : Acoes
{
    public abstract void Apply(ArgsSoquinho args);
}

public abstract class AcaoEvoluiu : Acoes
{
    public abstract void Apply(ArgsEvoluiu args);
}

public abstract class AcaoComprar : Acoes
{
    public abstract void Apply(ArgsComprar args);
}

public abstract class AcaoVender : Acoes
{
    public abstract void Apply(ArgsVender args);
}

public abstract class AcaoAtualizar : Acoes
{
    public abstract void Apply(ArgsAtualizar args);
}