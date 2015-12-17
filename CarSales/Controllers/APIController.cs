using System.Web.Mvc;
using CarSales.Models;
using System.Net;
using CarSales.Repositories;
using System.Collections.Generic;

namespace CarSales.Controllers
{
	public class APIController : Controller
	{
        private ICarRepository CarRepository;
        private IEnquiryRepository EnquiryRepository;

        public APIController(ICarRepository carRepo, IEnquiryRepository enquiryRepo) {
            CarRepository = carRepo;
            EnquiryRepository = enquiryRepo;
        }

        [HttpGet]
		public ActionResult Cars()
		{
            return Json(CarRepository.GetAll(), JsonRequestBehavior.AllowGet);
		}

		[HttpGet]
		public ActionResult Car(int? id)
		{
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = CarRepository.GetById(id.Value);
            if (car == null)
            {
                return HttpNotFound();
            }
            return Json(car, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		public ActionResult Enquiry(Enquiry model)
		{
			var response = new APIResponse ();
			if (string.IsNullOrEmpty (model.Email)) {
				response.Errors.Add (new APIResponse.Error (){
					Source = "Email",
					Message = "Email cannot be empty"
				});
			}

            if (string.IsNullOrEmpty (model.Name)) {
				response.Errors.Add (new APIResponse.Error (){
					Source = "Name",
					Message = "Name cannot be empty"
				});
			}

            if (response.Errors.Count > 0)
            {
                response.Success = false;
            }
            else {
                EnquiryRepository.Send(model);
            }

			response.Message = response.Success ? "Your enquiry is sent successfully" : "Please check the form";

			return Json(response);
		}
	}
}

