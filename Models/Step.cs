using System;
using System.ComponentModel.DataAnnotations;

namespace MindYourPsandQs.Models
{
    public class Step
    {
        [Key]
        public int StepId {get;set;}
        [Required(ErrorMessage = "Please provide a step.")]
        public string AStep {get;set;}
        [Required]
        public int ObjectiveId {get;set;}
        public Objective Objective {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}