using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTaskingWindowsAppSample
{
    public class Helper
    {
        Employee emp;
        static List<Employee> empList;

        static Helper()
        {
            //initializing the employee list
            empList = new List<Employee>();
        }

        public void SaveEmployeeDetails(string id, string name, string gender, string age)
        {            
            //filling the employee details to save
            emp = new Employee();
            emp.ID = id == string.Empty ? 0 : Convert.ToInt32(id);
            emp.Name = name;
            emp.Gender = gender;
            emp.Age = age == string.Empty ? 0 : Convert.ToInt32(age);

            //small validation
            if (emp.ID == 0 || emp.Name == string.Empty || emp.Gender == string.Empty || emp.Age == 0)
                MessageBox.Show("Please enter all the required details before saving");
            
            //storing the employee details to list
            empList.Add(emp);
        }

        public bool IsEmployeeFound(string id)
        {
            //setting default value
            bool found = false;

            foreach (var a in empList)
            {
                if (a.ID == Convert.ToInt32(id))
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

        public string GetName(string id)
        {
            //taking help of this for showing the actions are processing in sequence
            Thread.Sleep(5000);

            //returning the search result
            return empList.FirstOrDefault(x => x.ID == Convert.ToInt32(id)).Name;
        }

        public string GetGender(string id)
        {
            //taking help of this for showing the actions are processing in sequence
            Thread.Sleep(5000);

            //returning the search result            
            return empList.FirstOrDefault(x => x.ID == Convert.ToInt32(id)).Gender;
        }

        public int GetID(string id)
        {
            //taking help of this for showing the actions are processing in sequence
            Thread.Sleep(5000);

            //returning the search result            
            return empList.FirstOrDefault(x => x.ID == Convert.ToInt32(id)).ID;
        }

        public int GetAge(string id)
        {
            //taking help of this for showing the actions are processing in sequence
            Thread.Sleep(5000);

            //returning the search result            
            return empList.FirstOrDefault(x => x.ID == Convert.ToInt32(id)).Age;
        }
    }
}
