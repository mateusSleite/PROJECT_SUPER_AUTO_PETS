using System;
using System.Collections.Generic;

public abstract class Inimigo
{
    static Random rnd = new Random(Guid.NewGuid().GetHashCode());
    
    int maxTierMaquina = 1;

    public List<Type> TiposMaquina { get; set; } = new List<Type>
    {
        typeof(Martelo),
        typeof(ChaveDeFenda),
        typeof(Esteira),
        typeof(FuradeiraDeColuna),
        typeof(FornoIndustrialAGas),
        typeof(RetificaPlana)
    };

    public List<MaquinasAtb> TeamEnemy { get; set; } = new List<MaquinasAtb>();

    public Inimigo()
    {
        AdicionarMaquinas();
    }

    private void AdicionarMaquinas()
    {
        int size = rnd.Next(3, 6);

        for (int i = 0; i < size; i++)
        {
            Type maquinaType;
            do
            {
                maquinaType = TiposMaquina[rnd.Next(TiposMaquina.Count)];    
            } while ((int)maquinaType.GetProperty("Tier").GetValue(null) > maxTierMaquina);
            
            MaquinasAtb maquina = (MaquinasAtb)Activator.CreateInstance(maquinaType);
            TeamEnemy.Add(maquina);
        }
    }

    public void MaxTier(int rodada)
    {
        if (rodada % 2 == 1 && rodada <=11 && maxTierMaquina < 6)
            maxTierMaquina++;
    }

}
