using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PR46_2019_Web_projekat.Models.classes
{
    public class Comment
    {
        public int Id { get; set; }
        public int CenterId { get; set; }
        public string Username { get; set; }
        public string Content { get; set; }
        public int RatingGrade { get; set; }
        public bool Approved { get; set; }
    }
}