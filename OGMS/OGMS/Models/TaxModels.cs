using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace OGMS.Models
{
    public class TaxModels
    {
        public class LowProducerSearchCriteria
        {
            [DisplayName("Producer Name:")]
            public string ProducerName { get; set; }

            [DisplayName("Purchaser Name:")]
            public string PurchaserName { get; set; }

            [DisplayName("Operator Name:")]
            public string OperatorName { get; set; }

            [DisplayName("Lease Name:")]
            public string LeaseName { get; set; }

            [DisplayName("Start Date:")]
            public DateTime StartDate { get; set; }

            [DisplayName("End Date:")]
            public DateTime EndDate { get; set; }
        }

        public class HighCostSearchCriteria
        {
            [DisplayName("Taxpayer Name:")]
            public string TaxpayerName { get; set; }

            [DisplayName("Operator Name:")]
            public string OperatorName { get; set; }

            [DisplayName("County:")]
            public string County { get; set; }

            [DisplayName("Start Date:")]
            public DateTime StartDate { get; set; }

            [DisplayName("End Date:")]
            public DateTime EndDate { get; set; }
        }

        public class TwoYearSearchCriteria
        {
            [DisplayName("Taxpayer Name:")]
            public string TaxpayerName { get; set; }

            [DisplayName("Operator Name:")]
            public string OperatorName { get; set; }

            [DisplayName("County:")]
            public string County { get; set; }

            [DisplayName("Start Date:")]
            public DateTime StartDate { get; set; }

            [DisplayName("End Date:")]
            public DateTime EndDate { get; set; }
        }

        public class LowProducerTotals
        {
            public Int64 ProducerNumber { get; set; }

            public string ProducerName { get; set; }

            public Int64 PurchaserNumber { get; set; }

            public string PurchaserName { get; set; }

            public Int64 OperatorId { get; set; }

            public string OperatorName { get; set; }

            public Int64 LeaseNumber { get; set; }

            public string LeaseName { get; set; }

            public decimal LowProTotal { get; set; }
        }

        public class HighCostTotals
        {
            public Int64 TaxpayerNumber { get; set; }

            public string TaxpayerName { get; set; }

            public Int64 OperatorId { get; set; }

            public string OperatorName { get; set; }

            public Int64 LeaseNumber { get; set; }

            public string LeaseName { get; set; }

            public decimal HighCostTotal { get; set; }
        }

        public class TwoYearExemptTotals
        {
            public Int64 TaxpayerNumber { get; set; }

            public string TaxpayerName { get; set; }

            public Int64 OperatorId { get; set; }

            public string OperatorName { get; set; }

            public Int64 LeaseNumber { get; set; }

            public string LeaseName { get; set; }

            public decimal TwoYearTotal { get; set; }
        }
    }
}