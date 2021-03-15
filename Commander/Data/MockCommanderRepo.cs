using System.Collections.Generics;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0; HowTo = "Dummy data1", Line = "Dummy line1", Platform = "c#1"};
                new Command{Id = 1; HowTo = "Dummy data2", Line = "Dummy line2", Platform = "c#2"};
                new Command{Id = 2; HowTo = "Dummy data3", Line = "Dummy line3", Platform = "c#3"};
            }

            return commands;
        }

        public Command GetAppCommands(int id)
        {
            return new Command{Id = 0; HowTo = "Dummy data", Line = "Dummy line", Platform = "c#"};
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}