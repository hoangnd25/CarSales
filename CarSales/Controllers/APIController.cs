using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using CarSales.Models;
using CarSales.DAL;
using System.Net;

namespace CarSales.Controllers
{
	public class APIController : Controller
	{
        private CarContext db = new CarContext();

        [HttpGet]
		public ActionResult Cars()
		{
            return Json(db.Cars.ToList(), JsonRequestBehavior.AllowGet);
		}

		[HttpGet]
		public ActionResult Car(int? id)
		{
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
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
                db.Enquiries.Add(model);
                db.SaveChanges();
            }

			response.Message = response.Success ? "Your enquiry is sent successfully" : "Please check the form";

			return Json(response);
		}
	}
}

