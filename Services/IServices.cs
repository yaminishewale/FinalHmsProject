using HRMSProject.Models;

namespace HRMSProject.Service
{
    public interface IServices
    {
        IEnumerable<House> GetHouses();
    }
}
