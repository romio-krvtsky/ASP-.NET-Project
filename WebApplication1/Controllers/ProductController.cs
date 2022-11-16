using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Extensions;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;
        private readonly SuperMegaClass smc;
        int _pageSize;

        public ProductController(ApplicationDbContext context, SuperMegaClass smc)
        {
            _pageSize = 3;
            _context = context;
            this.smc = smc;
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo = 1)
        {
            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            //  list og groups to ViewData 
            ViewData["Groups"] = _context.DishGroups;

            // get id of current group and put it to tempdata
            ViewData["CurrentGroup"] = group ?? 0;

            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }

    }
}
