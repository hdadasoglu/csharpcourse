using System;

namespace Interfaces{
    class Program{
        public static void Main(string[] args){

            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DataBaseLogger dataBaseLogger = new DataBaseLogger();
            dataBaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}