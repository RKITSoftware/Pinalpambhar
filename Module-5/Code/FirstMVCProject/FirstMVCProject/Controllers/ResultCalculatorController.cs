using FirstMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class ResultCalculatorController : Controller
    {
        // GET: ResultCalculator
        public ActionResult Index()
        {
            return View(new ResultCalculator());
        }

        [HttpPost]

        public ActionResult Index(ResultCalculator c)
        {
            c.Total = c.OperatingSystem + c.CPP + c.ComputerNetwork + c.CompilerDesign + c.Math;
            c.Percentage = (c.Total * 100) / 500;
            return View(c);

        }
    }
}