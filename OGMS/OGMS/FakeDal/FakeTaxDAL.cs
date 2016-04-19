using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OGMS.Models;

namespace OGMS.FakeDal
{
    public class FakeTaxDAL
    {
        public List<TaxModels.LowProducerTotals> PopulateFakeLowProTotals()
        {
            List<TaxModels.LowProducerTotals> fakeData = new List<TaxModels.LowProducerTotals>();

            fakeData.Add(new TaxModels.LowProducerTotals
            {
                ProducerName = "Exxon Mobil",
                ProducerNumber = 845643415
            });

            return fakeData;
        }

        public List<TaxModels.HighCostTotals> PopulateFakeHighCostTotals()
        {
            List<TaxModels.HighCostTotals> fakeData = new List<TaxModels.HighCostTotals>();

            fakeData.Add(new TaxModels.HighCostTotals
            {
                TaxpayerName = "Exxon Mobil",
                TaxpayerNumber = 845643415
            });

            return fakeData;
        }

        public List<TaxModels.TwoYearExemptTotals> PopulateFakeTwoYearTotals()
        {
            List<TaxModels.TwoYearExemptTotals> fakeData = new List<TaxModels.TwoYearExemptTotals>();

            fakeData.Add(new TaxModels.TwoYearExemptTotals
            {
                TaxpayerName = "Exxon Mobil",
                TaxpayerNumber = 845643415
            });

            return fakeData;
        }
    }
}