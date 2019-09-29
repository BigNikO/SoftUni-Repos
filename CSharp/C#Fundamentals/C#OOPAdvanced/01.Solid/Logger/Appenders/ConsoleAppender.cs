namespace Logger.Appenders
{
    using System;

    using Layouts.Contracts;
    using Loggers.Enums;

    public class ConsoleAppender : Appender
    {

        public ConsoleAppender(ILayout layout)
        : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                this.MessagesCount++;
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
            }
        }

        public override string ToString()
        {
            return $"Appender {this.GetType().Name}: ConsoleAppender, Layout type: {this.Layout.GetType().Name}," +
                   $" Report level: {this.ReportLevel}, Messages appended: {this.MessagesCount}";
        }
    }
}
