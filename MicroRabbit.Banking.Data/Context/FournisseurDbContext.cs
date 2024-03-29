﻿
using MicroRabbit.GestionFournisseur.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Data.Context
{
    public class FournisseurDbContext : DbContext
    {
        public FournisseurDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Fournisseur> Fournisseurs { get; set; }
    }
}
