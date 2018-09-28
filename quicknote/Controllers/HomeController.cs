using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using quicknote.Models;

namespace quicknote.Controllers
{
    public class HomeController : Controller
    {
        quicknoteDatabase db = new quicknoteDatabase();

        // GET: Home
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Create(Note myNote)
        {
            myNote.Id = Guid.NewGuid();
            db.Notes.Add(myNote);
            db.SaveChanges();

            return RedirectToAction("MyNote", "Home", new { guid = myNote.Id });
        }

        public ActionResult MyNote(Guid guid)
        {
            Note _note = new Note();

            if (!string.IsNullOrEmpty(guid.ToString()))            
               _note = db.Notes.Find(guid);

            return View(_note);
        }
    }
}