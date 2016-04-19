using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace OGMS.Models
{
    public class W1Models
    {
        public class PermitsFiledPerOperator
        {
            public Int64 OperatorId { get; set; }

            public string OperatorName { get; set; }

            public decimal PermitAvg { get; set; }

            public Int64 TotalPermits { get; set; }
        }

        public class PermitsFiledPerLease
        {
            public Int64 OperatorId { get; set; }

            public string OperatorName { get; set; }

            public Int64 LeaseId { get; set; }

            public string LeaseName { get; set; }

            public decimal PermitAvg { get; set; }

            public Int64 TotalPermits { get; set; }
        }

        public class PermitFiledPerField
        {
            public Int64 OperatorId { get; set; }

            public string OperatorName { get; set; }

            public Int64 FieldNumber { get; set; }

            public string FieldName { get; set; }

            public decimal PermitAvg { get; set; }

            public Int64 TotalPermits { get; set; }
        }

        public class OperatorSearchCriteria
        {
            [DisplayName("Operator Name:")]
            public string OperatorName { get; set; }

            [DisplayName("Start Date:")]
            public DateTime StartDate { get; set; }

            [DisplayName("End Date:")]
            public DateTime EndDate { get; set; }

            [DisplayName("County:")]
            public string County { get; set; }
        }

        public class LeaseSearchCriteria
        {
            [DisplayName("Operator Name:")]
            public string OperatorName { get; set; }

            [DisplayName("Lease Name:")]
            public string LeaseName { get; set; }

            [DisplayName("Start Date:")]
            public DateTime StartDate { get; set; }

            [DisplayName("End Date:")]
            public DateTime EndDate { get; set; }

            [DisplayName("County:")]
            public string County { get; set; }
        }

        public class FieldSearchCriteria
        {
            [DisplayName("Operator Name:")]
            public string OperatorName { get; set; }

            [DisplayName("Field Name:")]
            public string FieldName { get; set; }

            [DisplayName("Start Date:")]
            public DateTime StartDate { get; set; }

            [DisplayName("End Date:")]
            public DateTime EndDate { get; set; }
        }
    }
}