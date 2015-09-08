using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.MODEL
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string OtherNames { get; set; }

        public string FullName
        {
            get { return (this.FirstName + " " + this.OtherNames); }
        }

        public char Gender { get; set; }
        public DateTime Dob { get; set; }
        public int AgeAnb { get; set; }
        public int MaritalStatus { get; set; }
        public string PlaceOfBirth { get; set; }
        public string ReligionBelief { get; set; }
        public double Height { get; set; }
        public string HeightUnit { get; set; }
        public double Weight { get; set; }
        public string WeightUnit { get; set; }







        public string Nationality { get; set; }
        public string OccupationClass { get; set; }
        public string AssuredOccupation { get; set; }



        //public Proposal Proposal { get; set; }
    }
}
