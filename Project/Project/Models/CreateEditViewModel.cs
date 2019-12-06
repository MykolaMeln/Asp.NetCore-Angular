using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class CreateUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Year { get; set; }
    }
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public int Year { get; set; }
    }
    public class EditRadioViewModel
    {
        public int RadioId { get; set; }
        public string Name { get; set; }
        public float Frequency { get; set; }
        public int Rating { get; set; }
    }
    public class CreateRadioViewModel
    {
        public string Name { get; set; }
        public float Frequency { get; set; }
        public int Rating { get; set; }
    }
    public class EditProhramViewModel
    {
        public int ProgramId { get; set; }
        public int radioid { get; set; }
        public string Name_program { get; set; }
        public string Period { get; set; }
        public string Hour_begin { get; set; }
        public string Hour_end { get; set; }
    }
    public class CreateProhramViewModel
    {
        public int radioid { get; set; }
        public string Name_program { get; set; }
        public string Period { get; set; }
        public string Hour_begin { get; set; }
        public string Hour_end { get; set; }
    }

    public class EditCommentViewModel
    {
        public int commentid { get; set; }
        public int userid { get; set; }
        public string username { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
    }
    public class CreateCommentViewModel
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
    }


}
