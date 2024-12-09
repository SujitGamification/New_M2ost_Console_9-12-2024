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
    
    public partial class tbl_kpi_scoring_master_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_kpi_scoring_master_details()
        {
            this.tbl_assessment_grid_details = new HashSet<tbl_assessment_grid_details>();
            this.tbl_assessment_mastery_score_details = new HashSet<tbl_assessment_mastery_score_details>();
            this.tbl_assessment_right_answer_details = new HashSet<tbl_assessment_right_answer_details>();
            this.tbl_content_asessment_completion_timeframe_details = new HashSet<tbl_content_asessment_completion_timeframe_details>();
            this.tbl_content_completion_notime_details = new HashSet<tbl_content_completion_notime_details>();
            this.tbl_user_kpi_data_log = new HashSet<tbl_user_kpi_data_log>();
        }
    
        public int ID_Scoring_Matrix { get; set; }
        public int ID_KPI { get; set; }
        public int ID_Assessment_Type { get; set; }
        public int Content_Assessment_ID { get; set; }
        public bool ApplyMasterScoreMultipleAttempts { get; set; }
        public bool ApplyRightAnswerMultipleAttempts { get; set; }
        public string IsActive { get; set; }
        public Nullable<int> created_by { get; set; }
        public System.DateTime created_date { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_assessment_grid_details> tbl_assessment_grid_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_assessment_mastery_score_details> tbl_assessment_mastery_score_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_assessment_right_answer_details> tbl_assessment_right_answer_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_content_asessment_completion_timeframe_details> tbl_content_asessment_completion_timeframe_details { get; set; }
        public virtual tbl_content_assessment_type_master_details tbl_content_assessment_type_master_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_content_completion_notime_details> tbl_content_completion_notime_details { get; set; }
        public virtual tbl_kpi_master_details tbl_kpi_master_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user_kpi_data_log> tbl_user_kpi_data_log { get; set; }
    }
}
