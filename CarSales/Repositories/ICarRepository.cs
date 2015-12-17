using CarSales.Models;

namespace CarSales.Repositories
{
    public interface IEnquiryRepository
    {
        void Send(Enquiry data);
    }
}
