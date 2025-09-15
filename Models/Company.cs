using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PraktikTracker.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string URL { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public bool SentViaWebsite { get; set; }
        [Required]
        public bool HasSentEmail { get; set; }
        public DateOnly EmailSent { get; set; }
        public DateOnly? FollowUpDate { get; set; }
        public Answer Answer { get; set; }

        public Company()
        {
            if (HasSentEmail)
            {
                EmailSent = DateOnly.FromDateTime(DateTime.Now);
            }
            FollowUpDate = DateOnly.FromDateTime(DateTime.Now.AddDays(14));
        }
    }
}