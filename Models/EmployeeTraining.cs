using System;
namespace MAS_PRO_Salon.Models
{
    public class EmployeeTraining
    {
        public EmployeeTraining()
        {
        }

        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }

        public int TrainingID { get; set; }

        public Training Training { get; set; }

        public DateTime AccuireDate { get; set; }
    }
}
