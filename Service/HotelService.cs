using Elekta.Model;
using Newtonsoft.Json;

namespace Elekta.Service
{
    public class HotelService : IHotelService
    {        
        public IEnumerable<Hotel> Get()
        {                                 
            return MappedHotelDetails();
        }

        public IEnumerable<Hotel>? Search(string name)
        {
            if (string.IsNullOrEmpty(name)) { return null; }
            
            return MappedHotelDetails()            
            .Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            .ToList();            
        }

        private static List<Hotel> MappedHotelDetails()
        {
            string hotelFilePath = File.ReadAllText("Data\\Hotels.json");
            return JsonConvert.DeserializeObject<List<Hotel>>(hotelFilePath) ?? [];
        }
    }
}
