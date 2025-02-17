﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeGestionDeCondominio.Models
{
	public class Empleado
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        [Required]
        public DateOnly FechaNacimiento { get; set; }
        [Required]
        public string? Cedula { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        [ForeignKey("Apartamento")]
        public int IdApartamento { get; set; }
        public ICollection<Apartamento>? apartamento { get; set; }

        [ForeignKey("Parqueo")]
        public int IdParqueo { get; set; }
        public ICollection<Parqueo>? parqueos { get; set; }
        public int Estado { get; set; }

    }
}

