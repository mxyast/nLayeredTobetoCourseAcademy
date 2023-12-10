using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity<Guid>
    {
     
        public string CategoryId { get; set; }
        public Category? Category { get; set; }
        public string InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
