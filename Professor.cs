namespace WindowsFormsApp6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Professor")]
    public partial class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codeProfessor { get; set; }

        [StringLength(100)]
        public string nameprofessor { get; set; }

        [StringLength(100)]
        public string lastnameprofessor { get; set; }

        public int? Idprofessor { get; set; }

        [StringLength(100)]
        public string fathername { get; set; }

        [Column(TypeName = "ntext")]
        public string birthday { get; set; }

        [StringLength(100)]
        public string Crosssection { get; set; }
    }
}
