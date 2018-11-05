using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PositionCandidate
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo NamePositition es Oblgatorio")]
        public string NamePositition { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo CreateDate es Obligatorio")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "El campo CreateBy es obligatorio")]
        public string CreateBy { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo ModifiedDate es Obligatorio")]
        public DateTime ModifiedDate { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El Campo ModifyBy es Obligatorio")]
        public string ModifyBy { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }

    }
}