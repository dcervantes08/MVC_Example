using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using OGMS.Models;
using System.Collections.Generic;
using OGMS.FakeDal;

namespace OGMS.Controllers
{
    public class OilController : Controller
    {
        private FakeOilDAL fakeOilDAL;

        public OilController()
        {
            fakeOilDAL = new FakeOilDAL();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult OilReportInfo()
        {
            return View("OilReportInfo");
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerOperator()
        {
            OilModel.OperatorSearchCriteria searchCriteria = new OilModel.OperatorSearchCriteria();
            
            return View("PerOperator", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult OilOperatorSearchResults(OilModel.OperatorSearchCriteria searchCriteria)
        {
            List<OilModel.OilProdPerOperator> operatorData = new List<OilModel.OilProdPerOperator>();

            operatorData = fakeOilDAL.PopulateFakeOilOperatorData();

            return PartialView("_OperatorSearchResults", operatorData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerField()
        {
            OilModel.FieldSearchCriteria searchCriteria = new OilModel.FieldSearchCriteria();

            return View("PerField", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult OilFieldSearchResults(OilModel.FieldSearchCriteria searchCriteria)
        {
            List<OilModel.OilProdPerField> fieldData = new List<OilModel.OilProdPerField>();

            fieldData = fakeOilDAL.PopulateFakeOilFieldData();

            return PartialView("_FieldSearchResults", fieldData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerLease()
        {
            OilModel.LeaseSearchCriteria searchCriteria = new OilModel.LeaseSearchCriteria();

            return View("PerLease", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult OilLeaseSearchResults(OilModel.LeaseSearchCriteria searchCriteria)
        {
            List<OilModel.OilProdPerLease> leaseData = new List<OilModel.OilProdPerLease>();

            leaseData = fakeOilDAL.PopulateFakeOilLeaseData();

            return View("_LeaseSearchResults", leaseData);
        }
    }
}