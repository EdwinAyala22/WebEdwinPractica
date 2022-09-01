using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebEdwinPractica.Models
{
    public class Registros
    {
        [Key]
        public int IdRegistro { get; set; }


        [DisplayName("Foto")]
        public Byte[] Imagen { get; set; }


        [DisplayName("Documento")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(20)")]
        public string Documento { get; set; }


        [DisplayName("Nombre")]
        //[StringLength(30)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }


        [DisplayName("Apellidos")]
        //[StringLength(30)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(30)")]
        public string Apellidos { get; set; }


        [DisplayName("Fecha Nacimiento")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Fecha requerida")]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public DateTime FechaNac { get; set; }


        [DisplayName("Dirección")]
        //[StringLength(100)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(100)")]

        public string Direccion { get; set; }


        [DisplayName("Celular")]
        //[StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(15)")]
        public string Celular { get; set; }


        [DisplayName("Género")]
        //[StringLength(1)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(1)")]
        public string Genero { get; set; }


        [DisplayName("Deporte")]
        //[StringLength(30)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(30)")]
        public string Deporte { get; set; }


        [DisplayName("Trabaja")]
        //[StringLength(2)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(2)")]
        public string Trabaja { get; set; }


        [DisplayName("Salario")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Dato requerido")]
        public decimal Sueldo { get; set; }


        [DisplayName("Estado")]
        //[StringLength(1)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Dato requerido")]
        [Column(TypeName = "varchar(1)")]
        public string Estado { get; set; }


        [DisplayName("Fecha de Registro")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Fecha de registro requerida")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        [Column(TypeName = "DateTime")]
        public DateTime FechaRegistro { get; set; }

    }
}
