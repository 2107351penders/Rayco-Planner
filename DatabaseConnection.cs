using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;

namespace RaycoPlannerSPAM
{
    public class DatabaseConnection
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=database.db; Version = 3; Compress = True;");

        /* Open de verbinding naar de database
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
    }
}