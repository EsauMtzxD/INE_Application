using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class TypeVote
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo NameVote es Obligatorio")]
        public string NameVote { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo CreateDate es Obligatorio")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "El campo CreateBy es Obligatorio")]
        public string CreateBy { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo ModifiedDate es Obligatorio")]
        public DateTime ModifiedDate { get; set; }

        [Required(ErrorMessage = "El campo ModifyBy es Obligatorio")]
        public string ModifyBy { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

    }
}