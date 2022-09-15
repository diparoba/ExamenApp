using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenApp.Models
{
    internal class Lugar
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(200)]
        public string ComidaTradicional { get; set; }
        [MaxLength(100)]
        public string Ubicacion { get; set; }
        [MaxLength(12)]
        public string NumeroContacto { get; set; }
    }
}
