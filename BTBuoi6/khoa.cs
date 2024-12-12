namespace BTBuoi6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("khoa")]
    public partial class khoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public khoa()
        {
            sinhvien = new HashSet<sinhvien>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ma_khoa { get; set; }

        [Required]
        [StringLength(100)]
        public string ten_khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sinhvien> sinhvien { get; set; }
    }
}
