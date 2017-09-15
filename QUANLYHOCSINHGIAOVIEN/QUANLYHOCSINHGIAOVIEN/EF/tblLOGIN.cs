namespace QUANLYHOCSINHGIAOVIEN.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLOGIN")]
    public partial class tblLOGIN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TenDN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
