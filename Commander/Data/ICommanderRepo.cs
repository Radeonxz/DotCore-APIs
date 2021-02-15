using System.Collections.Generics;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandBtId(int id);

        void CreateCommand(Command cmd);
    }
}