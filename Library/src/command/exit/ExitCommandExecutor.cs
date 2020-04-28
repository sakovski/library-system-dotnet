using System;
using System.Collections.Generic;
using System.Text;

namespace Library.src.command.exit
{
    public class ExitCommandExecutor : CommandExecutor
    {
        public void Execute()
        {
            Console.WriteLine("Thanks! Bye!");
            Environment.Exit(0);
        }
    }
}
