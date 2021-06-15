using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace questionnaire.Data.Models
{
    public class Answers
    {
        [Column("AnswerId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Anwer is  a required field.")]
        public string Answer { get; set; }
        public DateTime DateAdd { get; set; }

        // Nevigator Preperties
        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }

        [ForeignKey(nameof(Questions))]
        public int QuestionId { get; set; }

    }
}
