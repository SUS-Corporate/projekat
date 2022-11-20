using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PR46_2019_Web_projekat.Models.classes
{
    public class GroupTrainings
    {
        public int Id { get; set; }
        public string TrainingName { get; set; }
        public int Type { get; set; }
        public int CenterId { get; set; }
        public int Duration { get; set; }
        public DateTime Appointment { get; set; }
        public int Capacity { get; set; }
        public List<int> Visitors { get; set; }
        public bool Exist { get; set; }
    }
}