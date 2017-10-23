using ICRC.Domain.Entities;
using ICRC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICRC.WEB.Controllers
{
    public class RequestController : Controller
    {
        RequestService service = new RequestService();
        // GET: Request
        public ActionResult Index()
        {
            IEnumerable<Request> RequestLists = service.GetMany();
            return View(RequestLists);
        }

        // GET: Request/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Request/Create
        public ActionResult CreateRequest()
        {
            return View();
        }

        // POST: Request/Create
        [HttpPost]
        public ActionResult CreateRequest(Request rq)
        {
            try
            {
                service.Create(rq);
                service.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Request/Edit/5
        public ActionResult Edit(int id)
        {
            Request request = service.GetById(id);
            return View(request);
        }

        // POST: Request/Edit/5
           [HttpPost]
        //[AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Request request = service.GetById(id);
                request.From = Request.Form["From"];
                request.To = Request.Form["To"];
                ////request.Priority = Request.Form["Priority"];
                //request.ProductType = Request.Form["ProductType"];
                //request.Quantity = Request.Form["Quantity"];
                //request.Priority = 
                UpdateModel(request);
                service.Update(request);
                service.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Request/Delete/5
        public ActionResult Delete(int id)
        {
            Request request = service.GetById(id);

            if (request == null)
                return View("NotFound");
            else
                return View(request);
        }

        // POST: Request/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Request request = service.GetById(id);

            if (request == null)
                return View("NotFound");

            service.Remove(request);
            service.Commit();

            return View("Deleted");
        }
    }
}
