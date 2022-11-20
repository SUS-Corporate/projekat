using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PR46_2019_Web_projekat.Models.classes
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public string EMail { get; set; }
        public DateTime BirthDate { get; set; }
        public int Role { get; set; }
        public List<int> TrainingVisitor { get; set; }
        public List<int> TrainingTrainer { get; set; }
        public int CenterIdWorking { get; set; }
        public List<int> OwnedCenters { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Exist { get; set; }
    }
}