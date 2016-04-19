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
    public class GasController : Controller
    {
        private FakeGasDAL fakeGasDAL;

        public GasController()
        {
            fakeGasDAL = new FakeGasDAL();
        }

        //[Authorize]
        public ActionResult GasInfo()
        {
            return View("GasInfo");
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerOperator()
        {
            GasModels.OperatorSearchCriteria searchCriteria = new GasModels.OperatorSearchCriteria();

            return View("PerOperator", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GasOperatorSearchResults(GasModels.OperatorSearchCriteria searchCriteria)
        {
            List<GasModels.GasProdPerOperator> operatorData = new List<GasModels.GasProdPerOperator>();

            operatorData = fakeGasDAL.PopulateFakeGasOperatorData();

            return PartialView("_OperatorSearchResults", operatorData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerField()
        {
            GasModels.FieldSearchCriteria searchCriteria = new GasModels.FieldSearchCriteria();

            return View("PerField", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GasFieldSearchResults()
        {
            List<GasModels.GasProdPerField> fieldData = new List<GasModels.GasProdPerField>();

            fieldData = fakeGasDAL.PopulateFakeGasFieldData();

            return PartialView("_FieldSearchResults", fieldData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PerLease()
        {
            GasModels.LeaseSearchCriteria searchCriteria = new GasModels.LeaseSearchCriteria();

            return View("PerLease", searchCriteria);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GasLeaseSearchResults(GasModels.LeaseSearchCriteria searchForm)
        {
            List<GasModels.GasProdPerLease> leaseData = new List<GasModels.GasProdPerLease>();

            leaseData = fakeGasDAL.PopulateFakeGasLeaseData();

            return PartialView("_LeaseSearchResults", leaseData);
        }
    }
}