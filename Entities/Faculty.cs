using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain;

namespace Entities
{
    [Table("Faculties")]
    public class Faculty : DbEntity
    {
        [Column("Name")]
        [MaxLength(32)]
        public string Name { get; set; }

        public List<Group> Groups { get; set; }
    }
}