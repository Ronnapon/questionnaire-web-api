using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace questionnaire.Data.Models
{
    public class Questions
    {
        [Column("QuestionId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Question is  a required field.")]
        public string Question { get; set; }
        public DateTime DateAdd { get; set; }

        // Nevigetor Properties
        public List<Choices> Choices { get; set; }
    }
}
