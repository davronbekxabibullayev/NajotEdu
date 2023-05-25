using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotEdu.Application.Models.Group
{
    public class AddStudentGroupModel
    {
        public int StudentId { get; set; }
        public bool IsPayed { get; set; }
        public DateTime JoinedDate { get; set; }

    }
}
