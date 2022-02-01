using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace U1
{
   public class Comments
    {
        [Key]
        public int IdComments { get; set; }
        public DateTime Date { get; set; }
        public  string Comment { get; set; }
        public Usuario User { get; set; }
    }
}
