using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class TypeVote
    {
        /// <summary>
        /// Llave primaria de la tabla TypeVote.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Campo para guardar el nombre del tipo de voto.
        /// </summary>
        [Required(ErrorMessage = "El campo NameVote es Obligatorio")]
        public string NameVote { get; set; }

        /// <summary>
        /// Campo para guardar la fecha en que se creo el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo CreateDate es Obligatorio")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Campo para guardar el usuario que creo el registro.
        /// </summary>
        [Required(ErrorMessage = "El campo CreateBy es Obligatorio")]
        public string CreateBy { get; set; }

        /// <summary>
        /// Campo para guardar la ultima fecha en que se modifico el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo ModifiedDate es Obligatorio")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Campo para guardar el ultimo usuario que modifico el registro.
        /// </summary>
        [Required(ErrorMessage = "El campo ModifyBy es Obligatorio")]
        public string ModifyBy { get; set; }

        /// <summary>
        /// Relacion entre las tablas TypeVote - Vote.
        /// </summary>
        public virtual ICollection<Vote> Votes { get; set; }
    }
}