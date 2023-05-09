using FluentValidation.Results;
using MvcProject.BusinessLayer.Concrete;
using MvcProject.BusinessLayer.ValidationRules;
using MvcProject.DataAccessLayer.EntityFramework;
using MvcProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDal());
        MessageValidator messageValidator = new MessageValidator();
        
        public ActionResult Inbox()
        {
            var messageValue = mm.GetListInbox();
            return View(messageValue);
        }

        public ActionResult Sendbox()
        {
            var messageValue = mm.GetListSendbox();
            return View(messageValue);
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }

        public ActionResult GetSendboxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }


        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            ValidationResult result = messageValidator.Validate(message); 
            if(result.IsValid)
            {
                mm.MessageAddBL(message);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

       
    }
}