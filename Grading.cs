namespace WindowsFormsApp6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Grading")]
    public partial class Grading
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codestdent { get; set; }

        public int? codelesson { get; set; }

        [Column(TypeName = "ntext")]
        public string grade { get; set; }

        
    }
}
