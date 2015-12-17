using CarSales.DAL;
using CarSales.Models;

namespace CarSales.Repositories
{
    public class EnquiryEntityRepository : IEnquiryRepository
    {
        private CarContext db = new CarContext();

        public void Send(Enquiry data)
        {
            db.Enquiries.Add(data);
            db.SaveChanges();
        }
    }
}