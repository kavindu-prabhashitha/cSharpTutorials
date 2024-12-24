﻿using System;
using Microsoft.Extensions.Logging;


namespace LoggingProgram
{
    public class CustomLogger : ILogger
    {

        public void LogInformation(string message)

        {
            Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
        }

        public void LogError(Exception ex, string message)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now}: {message}\n{ex}");
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            throw new NotImplementedException();
        }
    }
}
