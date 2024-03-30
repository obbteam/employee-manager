using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00014809.DAL
{
    partial class EmployeeManager
    {

        //this code will allow us to sort the data by Name.
        public List<Employee> Sort()
        {
            var result = GetAll();
            result.Sort(new ByNameComparer());
            return result;

        }

        // //this code will show the data if IsActive is true.
        
        public List<Employee> Search(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.IsActive:
                    return GetAll().Where(a => a.IsActive.Equals(true)).ToList();
            }

            //if we are here - something went wrong
            return null;
        }
        //this code will show the data if IsActive is false.
        public List<Employee> SearchFalse(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.IsActive:
                    return GetAll().Where(a => a.IsActive.Equals(false)).ToList();
            }

            //if we are here - something went wrong
            return null;
        }



        private class ByNameComparer : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }


    }
}
