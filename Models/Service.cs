using System;
using System.Collections.Generic;

namespace MAS_PRO_Salon.Models
{
    public class Service
    {
        public Service()
        {
        }

        public int ServiceID { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public float Price { get; set; }

        public string Details { get; set; }

        private ICollection<Employee> _hairdressers = new List<Employee>();

        public ICollection<Employee> Hairdressers
        {
            get => _hairdressers;

            set
            {
                foreach(Employee employee in value){
                    if (!employee.EmployeeTypes.Contains(EmployeeType.HAIRDRESSER))
                        throw new Exception("Nie można dodać pracownika, który nie jest fryzjerem do usługi");
                }

                _hairdressers = value;
            }
        }

        public void AddHairdresser(Employee employee)
        {
            if (!_hairdressers.Contains(employee) && employee.EmployeeTypes.Contains(EmployeeType.HAIRDRESSER))
                _hairdressers.Add(employee);
            else
                throw new Exception("Pracownik jest już dodany do usługi albo nie jest fryzjerem");
        }

        public void RemoveHairdresser(Employee employee)
        {
            if (_hairdressers.Contains(employee))
                _hairdressers.Remove(employee);
        }
    }
}
