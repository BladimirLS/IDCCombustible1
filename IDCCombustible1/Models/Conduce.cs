using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IDCCombustible1.Models
{
    public partial class Conduce
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ficha { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public DateTime Fecha_Emision_Documento { get; set; }
        public int Numero_Documento { get; set; }
        public string Codigo_Activo_Fijo { get; set; }
        public int Numero_Documento_Externo { get; set; }
        public decimal Cantidad { get; set; }
        public int Kilometraje { get; set; }
        public DateTime AF_Fecha_Registro { get; set; }
    }
}
