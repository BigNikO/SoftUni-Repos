namespace Logger.Loggers
{
    using System.Linq;

    using Contracts;

    class LogFile:ILogFile
    {
        public void Write(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(c => c);
        }

        public int Size { get; private set; }
    }
}
