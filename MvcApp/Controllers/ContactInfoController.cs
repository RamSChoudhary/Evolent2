using MvcApp.Models;
using MVCApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class ContactInfoController : Controller
    {

        /// <summary>
        /// Created By : Ram.S Choudhary
        /// Created Date : 1 May 2018
        /// Purpose : This is the default method, responsible for returning the view
        /// when Contact Info page invokes
        /// REST URL and Method : GET: /ContactInfo/ 
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Index()
        {
            ContactInfoModel objContactInfoModel = new ContactInfoModel();
            var lstContactInfo = objContactInfoModel.GetContactDetails();
            return View(lstContactInfo);
        }

        /// <summary>
        /// Created By : Ram.S Choudhary
        /// Created Date : 1 May 2018
        /// Purpose : This is the default method, responsible for returning the view
        /// when Contact Info page invokes
        /// REST URL and Method : GET: /ContactInfo/Details/5 
        /// </summary>
        public ActionResult Details(int id)
        {
            ContactInfoModel objContactInfoModel = new ContactInfoModel();
            var ContactInfo = objContactInfoModel.GetContactDetails().FindAll(p => p.ContactId == id);

            return View(ContactInfo);
        }

        
        /// <summary>
        /// REST URL and Method : GET: /ContactInfo/Create 
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        //
        // POST: /ContactInfo/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    ContactInfo objContactInfo = new ContactInfo();

                    objContactInfo.ContactId = Convert.ToInt32(collection["ContactId"]) ;
                    objContactInfo.FirstName = collection["FirstName"];
                    objContactInfo.LastName = collection["LastName"];
                    objContactInfo.PhoneNumber = collection["PhoneNumber"];
                    objContactInfo.Email = collection["Email"];
                    objContactInfo.Status = Convert.ToBoolean(collection["Status"]);

                    ContactInfoModel objContactInfoModel = new ContactInfoModel();
                    objContactInfoModel.AddContactDetails(objContactInfo);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ContactInfo/Edit/5

        public ActionResult Edit(int id)
        {
            ContactInfoModel objContactInfoModel = new ContactInfoModel();
            var ContactInfo = objContactInfoModel.GetContactDetails().Find(p => p.ContactId == id);
            if (ContactInfo != null)
                return View(ContactInfo);
            else
                return View();
        }

        //
        // POST: /ContactInfo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ContactInfo objContactInfo = new ContactInfo();

                    objContactInfo.ContactId = id;
                    objContactInfo.FirstName = collection["FirstName"];
                    objContactInfo.LastName = collection["LastName"];
                    objContactInfo.PhoneNumber = collection["PhoneNumber"];
                    objContactInfo.Email = collection["Email"];
                    objContactInfo.Status = Convert.ToBoolean(collection["Status"]);

                    ContactInfoModel objContactInfoModel = new ContactInfoModel();
                    objContactInfoModel.UpdateContactDetails(objContactInfo);

                    
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ContactInfo/Delete/5

        public ActionResult Delete(int id)
        {
           
            return View();
        }

        //
        // POST: /ContactInfo/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ContactInfoModel objContactInfoModel = new ContactInfoModel();
                objContactInfoModel.DeleteContactDetails(id);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
