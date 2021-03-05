using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Entities
{
    [Table("Student")]
    public class Student : DbEntity
    {
        [Column("Name")]
        [MaxLength(32)]
        public string FirstName { get; set; }

        [Column("Last Name")]
        [MaxLength(32)]
        public string LastName { get; set; }

        public Guid Group_Id { get; set; }
        public Group Group { get; set; }
    }
}