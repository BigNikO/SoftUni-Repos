namespace Logger
{
    using Core;
    using Core.Contracts;

    class StartUp
    {
        static void Main()
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IEngine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
