namespace DogWalkingAppAuth.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dog")]
    public partial class Dog
    {
        
        public int DogId { get; set; }

        public string DogName { get; set; }

        public string DogBreed { get; set; }

        public List<DogWalking> DogWalkingList { get; set; } = new List<DogWalking>();
    }
}
