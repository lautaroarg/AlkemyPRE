using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace U1
{
   public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Posts>  Postss { get; set; }
        public ICollection <Comments> Commentss { get; set; }
    }
}
