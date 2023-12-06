using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Name { get; set; }
        public string Introduction { get; set; }
        public string FileUrl { get; set; }
        public string BackgroundUrl { get; set; }
        public string AboutHeader { get; set; }
        public string AboutContent { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ProfileUrl { get; set; }
        public string TwitterUrl  { get; set; }
        public string InstagramUrl{ get; set; }
        public string GithubUrl { get; set; }
        public string LinkedinUrl { get; set; }


    }
}
