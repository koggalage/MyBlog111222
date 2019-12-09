using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGuide.Contract.DTO
{
    public class PostFilterRequestDTO
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
