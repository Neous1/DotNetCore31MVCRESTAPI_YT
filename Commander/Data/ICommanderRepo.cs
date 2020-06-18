using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        //give me all the commands
        IEnumerable<Command> GetAppCommands();
        //return a single command
        Command GetCommandById(int id);
    }
}