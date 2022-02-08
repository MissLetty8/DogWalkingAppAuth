namespace DogWalkingAppAuth.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Walker")]
    public partial class Walker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WalkerID { get; set; }

        [Column("Walker Name")]
        [Required]
        [StringLength(50)]
        public string Walker_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }
    }
}
