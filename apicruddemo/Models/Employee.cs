using System;
using System.ComponentModel.DataAnnotations;

namespace apicruddemo.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Name Can Only be 50 Char")]
        public string Name { get; set; } 
    }
}
