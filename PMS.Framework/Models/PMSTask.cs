using PMS.Framework.Enums;
using PMS.Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PMS.Framework.Models
{
    [Table("Task")]
    public class PMSTask: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public StateEnum State { get; set; }
        public Project Project { get; set; }
        public ICollection<PMSTask> SubTasks { get; set; }
    }
}
