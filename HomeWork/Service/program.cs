using System;

namespace Class1
{
    public static class Config
    {
        public static string ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
    }
     public class DatabaseService
    {

        public void Connect()
        {
            string connectionString = Config.ConnectionString;

            // Логика подключения к базе данных
        }
    }

    public class LoggingService

    {

        public void Log(string message)

        {
            string connectionString = Config.ConnectionString;

            // Логика записи лога в базу данных

        }

    }
}
// В этом примере строка подключения хранится в одном месте - в классе Config. 
