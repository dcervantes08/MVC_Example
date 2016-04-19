using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OGMS.Models;

namespace OGMS.FakeDal
{
    public class FakeOilDAL
    {
        public List<OilModel.OilProdPerOperator> PopulateFakeOilOperatorData()
        {
            List<OilModel.OilProdPerOperator> fakeData = new List<OilModel.OilProdPerOperator>();

            fakeData.Add(new OilModel.OilProdPerOperator
            {
                OperatorId = 1
            });

            return fakeData;
        }

        public List<OilModel.OilProdPerLease> PopulateFakeOilLeaseData()
        {
            List<OilModel.OilProdPerLease> fakeData = new List<OilModel.OilProdPerLease>();

            fakeData.Add(new OilModel.OilProdPerLease
            {
                OperatorId = 1
            });

            return fakeData;
        }

        public List<OilModel.OilProdPerField> PopulateFakeOilFieldData()
        {
            List<OilModel.OilProdPerField> fakeData = new List<OilModel.OilProdPerField>();

            fakeData.Add(new OilModel.OilProdPerField
            {
                OperatorId = 1
            });

            return fakeData;
        }
    }
}