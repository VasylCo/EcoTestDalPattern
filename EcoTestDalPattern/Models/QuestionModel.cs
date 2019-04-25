using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcoTestDalPattern.Models
{
    public class QuestionModel
    {
        
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public string RightAnswer { get; set; }
    }
}