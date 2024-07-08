using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }//property
        public string Title { get; set; }
        public string Description { get; set; }
        public string DateInterval { get; set; }
        public string Location { get; set; }
    }
}
//variable -->method içinde tanımlanırsa
//field--> sınıf içinde tanımlanırsa 