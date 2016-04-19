using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OGMS.Models;

namespace OGMS.FakeDal
{
    public class FakeW1DAL
    {
        public List<W1Models.PermitsFiledPerOperator> PopulateFakeW1OperatorData()
        {
            List<W1Models.PermitsFiledPerOperator> fakeData = new List<W1Models.PermitsFiledPerOperator>();

            fakeData.Add(new W1Models.PermitsFiledPerOperator {
                OperatorId = 45615,
                OperatorName = "Anadarko EP",
                PermitAvg = 5,
                TotalPermits = 484
                });

            return fakeData;
        }

        public List<W1Models.PermitsFiledPerLease> PopulateFakeW1LeaseData()
        {
            List<W1Models.PermitsFiledPerLease> fakeData = new List<W1Models.PermitsFiledPerLease>();

            fakeData.Add(new W1Models.PermitsFiledPerLease
            {
                OperatorId = 1
            });

            return fakeData;
        }

        public List<W1Models.PermitFiledPerField> PopulateFakeW1FieldData()
        {
            List<W1Models.PermitFiledPerField> fakeData = new List<W1Models.PermitFiledPerField>();

            fakeData.Add(new W1Models.PermitFiledPerField
            {
                OperatorId = 1
            });

            return fakeData;
        }

    }
}