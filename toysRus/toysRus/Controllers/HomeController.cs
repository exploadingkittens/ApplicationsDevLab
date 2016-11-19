using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using toysRus.DataAccessLayer;
using System.Threading.Tasks;
using System.Data.Entity;


namespace toysRus.Controllers
{
    public class HomeController : RootController
    {
        private Context Context { get; set; }

        public HomeController(Context context)
        {
            Context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet][Route("ItemsInCategory/{categoryId}")]
        public async Task<ActionResult> ItemsInCategory(int categoryId)
        {
            var category = await Context.Categories.FirstAsync(cat => cat.ID == categoryId);

            if (category == null)
            {
                AddError($"Category with id {categoryId} doesn't exist");
            }

            ViewBag.ChosenCategory = category;
            return View("Index");
        }

        [HttpGet][Route("ClearCategory")]
        public ActionResult ClearCategory()
        {
            return RedirectToAction("Index");
        }
    }
}