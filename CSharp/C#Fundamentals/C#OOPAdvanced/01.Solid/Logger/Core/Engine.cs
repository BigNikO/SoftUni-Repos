namespace Logger.Core
{
    using System;

    using Contracts;

    class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                this.commandInterpreter.AddAppender(inputArgs);
            }

            string inputMessage = Console.ReadLine();

            while (inputMessage != "END")
            {
                string[] inputArgs = inputMessage.Split('|');
                this.commandInterpreter.AddMessage(inputArgs );
                inputMessage = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
