using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeGuide.EF.DomainModels
{
    [Table("Tbl_Post")]
    public partial class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Category Category { get; set; }
    }
}
