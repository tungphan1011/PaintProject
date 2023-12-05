﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Models
{
    public partial class Animal
    {
        public Animal()
        {
            ZooTrainerAnimal = new HashSet<ZooTrainerAnimal>();
        }

        [Key]
        [Column("Animail_id")]
        [StringLength(50)]
        public string AnimailId { get; set; }
        [Required]
        [Column("AnimalSpecies_id")]
        [StringLength(50)]
        public string AnimalSpeciesId { get; set; }
        [Column("Animal_gender")]
        public bool? AnimalGender { get; set; }
        [Required]
        [Column("Animal_Name")]
        [StringLength(50)]
        public string AnimalName { get; set; }
        [Required]
        [Column("Animal_DOB")]
        [StringLength(50)]
        public string AnimalDob { get; set; }
        [Column("Food_ID")]
        [StringLength(50)]
        public string FoodId { get; set; }
        [Required]
        [Column("Animal_Description")]
        public string AnimalDescription { get; set; }

        [ForeignKey("AnimalSpeciesId")]
        [InverseProperty("Animal")]
        public virtual AnimalSpecies AnimalSpecies { get; set; }
        [InverseProperty("Animal")]
        public virtual ICollection<ZooTrainerAnimal> ZooTrainerAnimal { get; set; }
    }
}