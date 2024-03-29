﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Domain.Models
{
    public class Fournisseur
    {
        [Key]
        public int FournisseurID { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Adresse { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail non valide")]
        public string Email { get; set; }
    }
}
