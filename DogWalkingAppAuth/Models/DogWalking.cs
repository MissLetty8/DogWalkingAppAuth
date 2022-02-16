namespace DogWalkingAppAuth.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DogWalking")]
    public partial class DogWalking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WalkId { get; set; }

        public DateTime WalkDate { get; set; }

        [Required]
        [StringLength(50)]
        public string WalkerName { get; set; }

        [Required]
        public int DogId { get; set; }

        public decimal Distance { get; set; }

        [Required]
        [StringLength(10)]
        public string Affirmations { get; set; }

      
    }
}
