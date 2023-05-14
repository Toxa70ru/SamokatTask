using Microsoft.AspNetCore.Mvc;
using SamokatTask.Data.Interfaces;

namespace SamokatTask.Controllers
{
    public class RanksController : Controller
    {
        public readonly IRank _rank;

        public RanksController(IRank irank)
        {
            _rank = irank;
        }
        public ViewResult List() {
            var ran = _rank.ranks;
            return View(ran);
        }
    }
}
