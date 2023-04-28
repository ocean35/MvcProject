using MvcProject.BusinessLayer.Concrete;
using MvcProject.DataAccessLayer.EntityFramework;
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
        
        public ActionResult Inbox()
        {
            var messageValue = mm.GetMessageList();
            return View(messageValue);
        }
    }
}