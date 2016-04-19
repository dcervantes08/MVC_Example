using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using OGMS.Models;
using OGMS.FakeDal;
using System.Collections.Generic;

namespace OGMS.Controllers
{
    public class W1Controller : Controller
    {
        private FakeW1DAL fakeW1DAL;

        public W1Controller()
        {
            fakeW1DAL = new FakeW1DAL();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult W1ReportInfo()
        {
            return View("W1ReportInfo");
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerOperator()
        {
            W1Models.OperatorSearchCriteria searchCriteria = new W1Models.OperatorSearchCriteria();

            return View("PerOperator", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult W1OperatorSearchResults(W1Models.OperatorSearchCriteria searchCriteria)
        {
            List<W1Models.PermitsFiledPerOperator> operatorData = new List<W1Models.PermitsFiledPerOperator>();

            operatorData = fakeW1DAL.PopulateFakeW1OperatorData();

            return PartialView("_OperatorSearchResults", operatorData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerField()
        {
            W1Models.FieldSearchCriteria searchCriteria = new W1Models.FieldSearchCriteria();

            return View("PerField", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult W1FieldSearchResults(W1Models.FieldSearchCriteria searchCriteria)
        {
            List<W1Models.PermitFiledPerField> fieldData = new List<W1Models.PermitFiledPerField>();

            fieldData = fakeW1DAL.PopulateFakeW1FieldData();

            return PartialView("_FieldSearchResults", fieldData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerLease()
        {
            W1Models.LeaseSearchCriteria searchCriteria = new W1Models.LeaseSearchCriteria();

            return View("PerLease", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult W1LeaseSearchResults(W1Models.LeaseSearchCriteria searchCriteria)
        {
            List<W1Models.PermitsFiledPerLease> leaseData = new List<W1Models.PermitsFiledPerLease>();

            leaseData = fakeW1DAL.PopulateFakeW1LeaseData();

            return PartialView("_LeaseSearchResults", leaseData);
        }
    }
}