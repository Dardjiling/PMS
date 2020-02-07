using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PMS.Framework.Models
{
    [Table("Project")]
    public class Project: BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; } 
        public DateTime? FinishDate { get; set; }
        public ICollection<Project> SubProjects { get; set; }
    }
}
