//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBHFL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_content_asessment_completion_timeframe_details
    {
        public int ID { get; set; }
        public int ID_Scoring_Matrix { get; set; }
        public int KPI_Type { get; set; }
        public int Category { get; set; }
        public Nullable<int> TimePeriod { get; set; }
        public decimal Points { get; set; }
        public string IsActive { get; set; }
        public Nullable<int> created_by { get; set; }
        public System.DateTime created_date { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    
        public virtual tbl_kpi_scoring_master_details tbl_kpi_scoring_master_details { get; set; }
    }
}
