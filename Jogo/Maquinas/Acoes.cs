public abstract class Acoes
{
    public abstract string Title { get; }
}

public abstract class AcaoSoquinho : Acoes
{
    public abstract void Apply(ArgsSoquinho args)
}

public abstract class AcaoEvoluiu : Acoes
{
    public abstract void Apply(ArgsEvoluiu args)
}