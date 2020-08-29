using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PolarHab.DbAssets
{
    public class Question
    {
        [Key]
        public int QuestionKey { get; set; }
        public string QuestionName { get; set; }
        public string QuestionDescription { get; set; }
        public string ImageName { get; set; }
        public string Wrong1Dialogue { get; set; }
        public string Wrong2Dialogue { get; set; }
        public string Wrong3Dialogue { get; set; }
        public string CorrectDialogue { get; set; }
        public string CorrectWhyTitle { get; set; }
        public string CorrectWhyDescription { get; set; }
        public string Answer1ModelJson { get; set; }
        public string Answer2ModelJson { get; set; }
        public string Answer3ModelJson { get; set; }
        public string Answer4ModelJson { get; set; }
        public string CookieTag { get; set; }
    }
}
