﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Entities
{
    public class Prohram
    {
        public int ProgramId { get; set; }
        public int radioid { get; set; }
   //     public Radio radioid { get; set; }
        public string Name_program { get; set; }
        public string Period { get; set; }
        public string Hour_begin { get; set; }
        public string Hour_end { get; set; }
    }
}
