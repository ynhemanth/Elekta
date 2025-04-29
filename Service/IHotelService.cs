using Elekta.Model;

namespace Elekta.Service
{
    public interface IHotelService
    {
        IEnumerable<Hotel> Get();
        IEnumerable<Hotel>? Search(string name);

    }
}
