using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PR46_2019_Web_projekat.Models.classes
{
    public class Enumerations
    {
        public enum Enum_Role
        {
            Visitor,
            Trainer,
            Owner,
            Undefined
        }

        public enum Enum_Gender
        {
            Male,
            Female,
            Other
        }

        public enum Enum_TrainingType
        {
            Yoga,
            LesMillsTone,
            BodyPump,
            Cardio,
            Other
        }
    }
}