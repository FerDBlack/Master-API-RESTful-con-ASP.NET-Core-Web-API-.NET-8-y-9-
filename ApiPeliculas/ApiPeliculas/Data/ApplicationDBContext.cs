﻿using ApiPeliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base (options)
        {
            
        }

        public DbSet<Categoria> categorias { get; set; }

    }
}
