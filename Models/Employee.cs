using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_PRO_Salon.Models
{

    [Table("Employees")]
    public class Employee : Person
    {

        public Employee()
        {
            EmployeeTypes = new List<EmployeeType>();
        }

        public float HourlyRate { get; set; }

        public Seniority Seniority { get; set; }

        public ICollection<EmployeeType> EmployeeTypes { get; set; }

        public Address Address { get; set; }

        private string _territory;

        public int? ManagerID { get; set; }

        public string Territory {
            //Check if Employee is Manager current territory
            get
            {
                if (EmployeeTypes.Contains(EmployeeType.MANAGER))
                    return _territory;
                else
                    return null;
            }
            //Check if Employee is Manager and set territory
            set
            {
                if (EmployeeTypes.Contains(EmployeeType.MANAGER))
                    _territory = value;
                else
                    _territory = null;
            }
        }

        private ICollection<Specialization> _specializations = new List<Specialization>();

        public ICollection<Specialization> Specializations
        {
            //Check if Employee is Hairdresser and return Employee's specializations as List
            get
            {
                if (EmployeeTypes.Contains(EmployeeType.HAIRDRESSER))
                    return _specializations;
                else
                    return null;
            }
            //Check if Employee is Hairdresser and set specializations to recived list
            set
            {
                if (EmployeeTypes.Contains(EmployeeType.HAIRDRESSER))
                    _specializations = value;
            }
        }

        //Add employee type if not added before
        public void AddEmployeeType(EmployeeType employeeType) {
            if (!EmployeeTypes.Contains(employeeType))
                EmployeeTypes.Add(employeeType);
        }

        //Remove employee type if it's one of existing types of employee
        public void RemoveEmployeeType(EmployeeType employeeType) {
            if (EmployeeTypes.Contains(employeeType))
                EmployeeTypes.Remove(employeeType);
        }

        //Add specialization to specializations List if Employee is Hairdresser and specialization not added before
        public void AddSpecialization(Specialization specialization) {
            if (EmployeeTypes.Contains(EmployeeType.HAIRDRESSER) && !Specializations.Contains(specialization))
                Specializations.Add(specialization);
        }

        //Remove specialization from specializations List if Employee is Hairdresser and specialization is one of employee specializations
        public void RemoveSpecialization(Specialization specialization)
        {
            if (EmployeeTypes.Contains(EmployeeType.HAIRDRESSER) && Specializations.Contains(specialization))
                Specializations.Remove(specialization);
        }

        //Count and return salary based on hourly rate and worked hours
        public float GetSalary(float workedHours) {
            return workedHours * HourlyRate;
        }
    }
}
