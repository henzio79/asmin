namespace ASM_UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ms_job_level
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ms_job_level()
        {
            //ms_employee_detail = new HashSet<ms_employee_detail>();
            ms_user_rights = new HashSet<ms_user_rights>();
        }

        [Key]
        public int job_level_id { get; set; }

        [StringLength(6)]
        public string job_level_code { get; set; }

        [StringLength(50)]
        public string job_level_name { get; set; }

        public bool? fl_active { get; set; }

        public DateTime? created_date { get; set; }

        public int? created_by { get; set; }

        public DateTime? updated_date { get; set; }

        public int? updated_by { get; set; }

        public DateTime? deleted_date { get; set; }

        public int? deleted_by { get; set; }

        public int? org_id { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ms_employee_detail> ms_employee_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ms_user_rights> ms_user_rights { get; set; }
    }
}
