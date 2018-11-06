using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PositionCandidate
    {
        /// <summary>
        /// Llave primaria de la tabla PositionCandidate.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Campo para guardar la posicion del candidato.
        /// </summary>
        [Required(ErrorMessage = "El campo NamePositition es Obligatorio")]
        public string NamePositition { get; set; }

        /// <summary>
        /// Campo para guardar la fecha en que se creo el registro.
        /// </summary>
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo CreateDate es Obligatorio")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Campo para guardar el usuario que creo el registro.
        /// </summary>
        [Required(ErrorMessage = "El campo CreateBy es obligatorio")]
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
        [StringLength(30)]
        [Required(ErrorMessage = "El Campo ModifyBy es Obligatorio")]
        public string ModifyBy { get; set; }

        /// <summary>
        /// Relacion entre las tablas PositionCandidate - Candidate.
        /// </summary>
        public virtual ICollection<Candidate> Candidates { get; set; }

    }
}