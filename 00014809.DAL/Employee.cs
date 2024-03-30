using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _00014809;

namespace _00014809.DAL
{
    public class Employee
    {
        private string name;
        private DateTime startDate;
        private DateTime dischargeDate;

        public int Id { get; set; }
        public string Name
        {
            get => name;
            set
            {
                //check if the name is empty
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");

                

                name = value;
            }
        }
        public bool IsActive { get; set; }
        public DateTime StartDate
        {
            get => startDate;
            set
            {
               
                if (value.Date > DateTime.Now) //time validation for future
                    throw new Exception("You can not choose from the future");
                startDate = value;
            }
        }
        public DateTime DischargeDate
        {
            get => dischargeDate;
            set
            {
                if (value.Date > DateTime.Now) //time validation for future
                    throw new Exception("You can not choose from the future");
                dischargeDate = value;
            }
        }
        
        
    }
    
}
