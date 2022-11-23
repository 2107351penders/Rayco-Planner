using System.Text.Json;

namespace RaycoPlannerSPAM
{
    internal class HRConnection
    {
        private readonly HttpClient client = new HttpClient();

        private string baseURL;

        public HRConnection(string baseURL)
        {
            this.baseURL = baseURL;
        }

        // TODO deze class uit factoreren; we gebruiken de name niet
        internal class Availability
        {
            public IList<int>? availability { get; set; }
            public string? name { get; set; }
        }

        /* Haal de projectleden op vanuit de HR tool en maak Projectlid objecten aan
         * 
         * Geeft een lijst van Projectlid objecten. Bij een onverwachte response van de
         * HR tool wordt een null-lijst teruggegeven
         */
        public List<Projectlid>? getProjectleden()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var stringTask = client.GetStringAsync(baseURL + "/employees");

            List<Projectlid> list = new List<Projectlid>();

            try
            {
                IDictionary<string, string>? employeeIndex =
                    JsonSerializer.Deserialize<IDictionary<string, string>>(stringTask.Result);

                if (employeeIndex != null)
                {
                    foreach (string key in employeeIndex.Keys)
                    {
                        int id;
                        string name = employeeIndex[key];

                        if (!Int32.TryParse(key, out id))
                        {
                            return null;
                        }

                        int[]? beschikbaarheid = getBeschikbaarheid(id);

                        if (beschikbaarheid != null)
                        {
                            Projectlid projectlid = new Projectlid(id, name, "Projectlid", beschikbaarheid);

                            list.Add(projectlid);
                        }
                        else return null;
                    }
                    return list;
                }
                return null;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("HR systeem communicatiefout: " + ex.Message);
            }
            return null;
        }

        /* Haal de beschikbaarheid van een projectlid op vanuit de HR tool
         * 
         * Geeft een lijst van int die de beschikbaarheid van het projectlid weergeeft.
         * Bij een onverwachte response van de HR tool wordt een null-lijst teruggegeven
         */
        public int[]? getBeschikbaarheid(int id, int jaar = 2022, int weekNr = 3)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var stringTask = client.GetStringAsync(baseURL + "/employee/" + id + "/availability/" + jaar + "/" + weekNr);

            int[] beschikbaarheid = new int[7];

            try
            {
                Availability? availability =
                    JsonSerializer.Deserialize<Availability>(stringTask.Result);

                if (availability != null &&
                    availability.availability != null &&
                    availability.availability.Count == 7)
                {
                    for (var i = 0; i < 7; i++)
                    {
                        beschikbaarheid[i] = availability.availability[i];
                    }
                    return beschikbaarheid;
                }
                return null;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("HR systeem communicatiefout: " + ex.Message);
            }
            return null;
        }
    }
}