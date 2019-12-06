using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Entities
{
    public class Comment
    {
        public int commentid { get; set; }
        public string userid { get; set; }
        public string username { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
    }
}
