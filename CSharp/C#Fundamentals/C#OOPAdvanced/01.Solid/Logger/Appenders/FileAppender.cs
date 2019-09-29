using Logger.Loggers.Enums;

namespace Logger.Appenders
{
    using System;
    using System.IO;

    using Layouts.Contracts;
    using Loggers.Contracts;

    class FileAppender : Appender
    {

        private readonly ILogFile logFile;

        public int MessagesCount { get; private set; }

        private const string path = "log.txt";

        public FileAppender(ILayout layout, ILogFile logFile)
        : base(layout)
        {
            this.logFile = logFile;
        }
        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                this.MessagesCount++;
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) +
                                 Environment.NewLine;
                this.logFile.Write(content);
                File.AppendAllText(path, content);
            }
        }

        public override string ToString()
        {
            return $"Appender {this.GetType().Name}: ConsoleAppender, Layout type: {this.Layout.GetType().Name}," +
                   $" Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended: {this.MessagesCount}, " +
                   $"File size: {this.logFile.Size}";
        }

    }
}
