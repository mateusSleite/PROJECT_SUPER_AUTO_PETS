using System;
using System.Collections.Generic;

public abstract class Team
{
    protected Stack<MaquinasAtb> TeamPlayer = new Stack<MaquinasAtb>();
}

public class PlayerTeam : Team
{
    public void AddMachine(MaquinasAtb machine)
    {
        TeamPlayer.Push(machine);
    }

    public void RemoveMachine(MaquinasAtb machine)
    {

        if (TeamPlayer.Peek() == machine)
        {
            TeamPlayer.Pop();
        }
        else
        {
            Console.WriteLine("Máquina não encontrada no topo da pilha!");
        }
    }
}
