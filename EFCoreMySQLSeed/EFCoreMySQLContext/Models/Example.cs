using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreMySQLContext.Models
{
    [Table("example")]
    public class Example
    {
        [Key]
        public int ExampleId { get; set; }

        [StringLength(255)]
        public string ExampleName { get; set; }

        [StringLength(255)]
        public string ExampleDesc { get; set; }
    }
}
