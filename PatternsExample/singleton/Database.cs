using System;

namespace PatternsExample.singleton
{
    public class Database
    {
        private static Database _instance;

        private Database()
        {
            Console.WriteLine("установил соединение с бд");
        }

        public static Database GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }

            return _instance;
        }
    }
}