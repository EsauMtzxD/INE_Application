using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Vote
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo VoteDate es Obligatorio")]
        public DateTime VoteDate { get; set; }

        [ForeignKey("TypeVote")]
        public int IdTypeVote { get; set; }
        public TypeVote TypeVote { get; set; }

        [ForeignKey("Candidate")]
        public int IdCandidate { get; set; }
        public Candidate Candidate { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El Campo CreateDate Es Obligatorio")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "El campo CreateBy es Obligatorio")]
        public string CreateBy { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo ModifiedDate Es Obligatorio")]
        public DateTime ModifiedDate { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "El campo ModifyBy es Obligatorio")]
        public string ModifyBy { get; set; }

    }
}