using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CommentViewModel
    {
        public int commentid { get; set; }
        public string userid { get; set; }
        public string username { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
    }
}
