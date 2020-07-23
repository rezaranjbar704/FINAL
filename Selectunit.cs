namespace WindowsFormsApp6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Selectunit")]
    public partial class Selectunit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codestdent { get; set; }

        public int? codelesson { get; set; }

        [StringLength(100)]
        public string namelesso { get; set; }

        [Column(TypeName = "ntext")]
        public string course { get; set; }

        public int? codeProfessor { get; set; }

        [Column(TypeName = "ntext")]
        public string startdate { get; set; }

        [Column(TypeName = "ntext")]
        public string examday { get; set; }

        [StringLength(100)]
        public string field { get; set; }
    }
}
