using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WepApi.DataAccess.Models
{
    public class Employee : DbBase
    {
        public DateTime BirthDate { get; set; }

        [Required]
        public char Sex { get; set; }

        [MaxLength(50)]
        public int Salary { get; set; }

        public Employee Supervisor { get; set; }

        public ICollection<Employee> Subordinates { get; set; }

        public ICollection<WorksWith> Clients { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public Branch Manages { get; set; }
    }
}