using Newtonsoft.Json;
using ProjectUI.Models;
using System.Globalization;
using System.Net;
using System.Text;

namespace ProjectUI.Helpers
{
    public static class UniversityHelper
    {
        public static List<UniversityModel> GetUniversities()
        {
            var List = new List<UniversityModel>();
            try
            {
                string URL = "http://universities.hipolabs.com/search?country=Turkey";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var result = reader.ReadToEnd();
                    List = JsonConvert.DeserializeObject<List<UniversityModel>>(result);
                }
            }
            catch (Exception ex)
            {
                List = new List<UniversityModel>();
            }
            return List;


        }
    }
}
