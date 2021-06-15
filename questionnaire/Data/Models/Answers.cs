using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questionnaire.Data.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        
        // Nevigator Preperties
        public int QuestionId { get; set; }

    }
}
