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
    [Table("Group")]
    public class Group : DbEntity
    {
        [Column("Name")]
        [MaxLength(32)]
        public string Name { get; set; }

        public int Faculty_Id { get; set; }
        public Faculty Faculty { get; set; }
        public List<Student> Students { get; set; }
    }
}