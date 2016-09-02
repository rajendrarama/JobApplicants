using JobApplicants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobApplicants.Repository
{
    public class ApplicantRepository : IApplicantRepository
    {
        List<ApplicantDetails> _applicantDetails = new List<ApplicantDetails>();

        public ApplicantRepository()
        {
            _applicantDetails.Add(new ApplicantDetails { Id = 1, Name = "Applicant 1", DOB = "01/01/1980", WorkExperience = "C#" });
            _applicantDetails.Add(new ApplicantDetails { Id = 2, Name = "Applicant 2", DOB = "02/02/1981", WorkExperience = "Java" });
            _applicantDetails.Add(new ApplicantDetails { Id = 3, Name = "Applicant 3", DOB = "03/03/1982", WorkExperience = "Scala" });
            _applicantDetails.Add(new ApplicantDetails { Id = 4, Name = "Applicant 4", DOB = "04/04/1983", WorkExperience = "Html" });
            _applicantDetails.Add(new ApplicantDetails { Id = 5, Name = "Applicant 5", DOB = "05/05/1984", WorkExperience = "C++" });
            _applicantDetails.Add(new ApplicantDetails { Id = 6, Name = "Applicant 6", DOB = "06/06/1985", WorkExperience = "Angular JS" });
            _applicantDetails.Add(new ApplicantDetails { Id = 7, Name = "Applicant 7", DOB = "07/07/1986", WorkExperience = "Web API" });
            _applicantDetails.Add(new ApplicantDetails { Id = 8, Name = "Applicant 8", DOB = "08/08/1987", WorkExperience = "WCF" });
        }
        
        public List<ApplicantDetails> GetApplicants()
        {
            return _applicantDetails;

        }
        public ApplicantDetails GetApplicantById(int? id)
        {
            return _applicantDetails.Find(x => x.Id == id);
        }
    }
}