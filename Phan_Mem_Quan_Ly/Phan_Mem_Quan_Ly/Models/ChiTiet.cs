namespace Phan_Mem_Quan_Ly.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTiet")]
    public partial class ChiTiet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ma { get; set; }

        public int? MaHoaDon { get; set; }

        public int? MaMon { get; set; }

        public int? SoLuong { get; set; }

        public int? ThanhTien { get; set; }

        public virtual Hoa_Don Hoa_Don { get; set; }

        public virtual Mon Mon { get; set; }
    }
}
