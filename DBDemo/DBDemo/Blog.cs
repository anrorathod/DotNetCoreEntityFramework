using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DBDemo
{
    public class Blog
    {
        public int BlogId { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
    }
}
