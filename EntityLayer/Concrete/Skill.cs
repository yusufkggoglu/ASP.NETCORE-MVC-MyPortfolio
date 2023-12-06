using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public int Value { get; set; }
    }
}
