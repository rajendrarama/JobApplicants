using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobApplicants.Models
{
    public class ApplicantDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string WorkExperience { get; set; }
    }
}