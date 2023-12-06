using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string Header { get; set; }
        public string SubHeader { get; set; }
        public string Content { get; set; }
    }
}
