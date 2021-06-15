using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace questionnaire.Data.Models
{
    public class Choices
    {
        [Column("ChoiceId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Choice is  a required field.")]
        public string Choice { get; set; }

        // Nevigator Properties
        [ForeignKey(nameof(Questions))]
        public int QuestionId { get; set; }
        public Questions question { get; set; }
    }
}
