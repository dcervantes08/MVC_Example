using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OGMS.FakeDal;
using OGMS.Models;

namespace OGMS.Controllers
{
    public class SeveranceTaxController : Controller
    {
        private FakeTaxDAL fakeTaxDAL;

        public SeveranceTaxController()
        {
            fakeTaxDAL = new FakeTaxDAL();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult TaxInfo()
        {
            return View("TaxReportInfo");
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult LowProducer()
        {
            TaxModels.LowProducerSearchCriteria searchCriteria = new TaxModels.LowProducerSearchCriteria();

            return View("LowProducer", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult LowProSearchResults(TaxModels.LowProducerSearchCriteria searchCriteria)
        {
            List<TaxModels.LowProducerTotals> lowProData = new List<TaxModels.LowProducerTotals>();

            lowProData = fakeTaxDAL.PopulateFakeLowProTotals();

            return PartialView("_LowProSearchResults", lowProData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult HighCost()
        {
            TaxModels.HighCostSearchCriteria searchCriteria = new TaxModels.HighCostSearchCriteria();

            return View("HighCost", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult HighCostSearchResults(TaxModels.HighCostSearchCriteria searchCriteria)
        {
            List<TaxModels.HighCostTotals> highCostData = new List<TaxModels.HighCostTotals>();

            highCostData = fakeTaxDAL.PopulateFakeHighCostTotals();

            return PartialView("_HighCostSearchResults", highCostData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult TwoYearExempt()
        {
            TaxModels.TwoYearSearchCriteria searchCriteria = new TaxModels.TwoYearSearchCriteria();

            return View("TwoYearExempt", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult TwoYearExemptSearchResults(TaxModels.TwoYearSearchCriteria searchCriteria)
        {
            List<TaxModels.TwoYearExemptTotals> twoYearData = new List<TaxModels.TwoYearExemptTotals>();

            twoYearData = fakeTaxDAL.PopulateFakeTwoYearTotals();

            return PartialView("_TwoYearSearchResults", twoYearData);
        }
    }
}