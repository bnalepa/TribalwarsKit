using System.Numerics;

namespace TribalwarsKit.DataGetter
{
    public class UpdateData
    {
        public static async Task<string> GetDataFromWebsite(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responeData = await response.Content.ReadAsStringAsync();
                    return responeData;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    return null;
                }
            }
        }
        public static void SaveStringAsTxt(string text, string filePath)
        {
            try
            {
                File.WriteAllText(filePath, text);
                Console.WriteLine("String saved as a text file.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }



        public static async Task UpdateDatabase(string server, string type)
        {
            string websiteUrl = $"https://{server}.plemiona.pl/map/{type}.txt";
            string responeData = await GetDataFromWebsite(websiteUrl);

            if (responeData != null)
            {
                string filePath = $".\\DataFiles\\{type}.txt";

                SaveStringAsTxt(responeData, filePath);

            }
            else
            {
                // TO DO
                Console.WriteLine("Failed to retrieve XML data from the website.");
            }
        }
        public static async Task CheckSync(string server, string type)
        {
            //ADD IF 
            UpdateDatabase(server, type);
        }

    }
}
