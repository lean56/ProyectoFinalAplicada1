﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<EntradaProductos> Entrada { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Clientes> Cliente { get; set; }

        public Contexto() : base("Constr") { }
    }
}
