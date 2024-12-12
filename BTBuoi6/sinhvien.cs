namespace BTBuoi6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sinhvien")]
    public partial class sinhvien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string ten { get; set; }

        public double? diem_trung_binh { get; set; }

        public int? ma_khoa { get; set; }

        public virtual khoa khoa { get; set; }
    }
}
