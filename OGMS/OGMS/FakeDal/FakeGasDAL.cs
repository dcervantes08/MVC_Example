using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OGMS.Models;

namespace OGMS.FakeDal
{
    public class FakeGasDAL
    {
        public List<GasModels.GasProdPerOperator> PopulateFakeGasOperatorData()
        {
            List<GasModels.GasProdPerOperator> fakeData = new List<GasModels.GasProdPerOperator>();

            fakeData.Add(new GasModels.GasProdPerOperator {
                OperatorId = 45615,
                OperatorName = "Anadarko EP",
                ProdAvg = 184645,
                TotalProd = 945546484
                });

            return fakeData;
        }

        public List<GasModels.GasProdPerLease> PopulateFakeGasLeaseData()
        {
            List<GasModels.GasProdPerLease> fakeData = new List<GasModels.GasProdPerLease>();

            fakeData.Add(new GasModels.GasProdPerLease
            {
                OperatorId = 1
            });

            return fakeData;
        }

        public List<GasModels.GasProdPerField> PopulateFakeGasFieldData()
        {
            List<GasModels.GasProdPerField> fakeData = new List<GasModels.GasProdPerField>();

            fakeData.Add(new GasModels.GasProdPerField
            {
                OperatorId = 1
            });

            return fakeData;
        }

    }
}