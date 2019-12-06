using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.DTO
{
    public class UserDTO
    {
      /*  public int Year { get; set; }
        public int Index { get; set; }
        public float Kredyt { get; set; }*/

        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}
