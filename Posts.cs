using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace U1
{
   public class Posts
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public Usuario User { get; set; }
    }
}
