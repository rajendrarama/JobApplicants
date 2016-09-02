using JobApplicants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicants.Repository
{
    public interface IApplicantRepository
    {
        List<ApplicantDetails> GetApplicants();

        ApplicantDetails GetApplicantById(int? id);
    }
}
