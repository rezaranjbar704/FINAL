namespace WindowsFormsApp6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("student")]
    public partial class student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        

        public int codestdent { get; set; }

        [StringLength(100)]
        public string namestudent { get; set; }

        [StringLength(100)]
        public string lastnamestudent { get; set; }

       
        public int Idstudent { get; set; }

        [StringLength(100)]
        public string fathername { get; set; }

        [Column(TypeName = "ntext")]
        public string birthday { get; set; }

        [StringLength(100)]
        public string field { get; set; }
    }
}
