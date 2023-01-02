using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace RaycoPlannerSPAM
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        public static string dbname = "database.db";

        SQLiteConnection connection = new SQLiteConnection($"Data Source={dbname}; Version = 3; Compress = True;");

        private DatabaseConnection() { }

        public static DatabaseConnection GetInstance()
        {
            if (_instance == null)
                _instance = new DatabaseConnection();
            return _instance;
        }

        // 

        

        /* Open de verbinding naar de databasedb
         * 
         * Geeft /true/ als de verbinding succesvol geopend is
         * 
         * Geeft /false/ als de verbinding mislukt is
         */
        public bool openDatabaseConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        
        /* Check inloggegevens van gebruiker
         * 
         * Geeft /true/ als id en wachtwoord juist zijn
         * 
         * Geeft /false/ als dit niet zo is
         */
        public bool loginGebruiker(string naam, string password)
        {
            return true; // DEBUGGING
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT password FROM Login WHERE userNaam={naam}";
            
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Read();
            
            string wachtwoord = sqlite_datareader.GetString(0);
            
            if (wachtwoord == password) return true;
            else return false;
        }

        public void setConnectionString(string connectionString)
        {
            dbname = connectionString;
        }
    }
}