using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AddressBookLINQ
{
    public class AddressBookManagement
    {
        public DataTable dataTable = new DataTable();
        public AddressBookManagement()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(double));
            dataTable.Columns.Add("PhoneNumber", typeof(double));
            dataTable.Columns.Add("Email", typeof(string));

            // Creating rows and adding data into row
            dataTable.Rows.Add("Sumit", "Patel", "Ugwa", "Akola", "Maharashtra", 444006, 9890989065, "Sumit121@gmail.com");
            dataTable.Rows.Add("Viraj", "Patel", "Akola", "Vidarbha", "Maharshtra", 444008, 9565956263, "Viraj11@gmail.com");
            dataTable.Rows.Add("Rohit", "Sharma", "Mumbai", "NaviMumbai", "MH", 111004, 8546365412, "Rohit10@gmail.com");
            dataTable.Rows.Add("Virat", "Kohli", "Mall", "Delhii", "Dehli", 555645, 9874562635, "Virat14@gmail.com");
            dataTable.Rows.Add("Rahul", "Kl", "PHmall", "Pune", "Maharashtra", 444008, 9896562635, "Rahul005@gmail.com");
            dataTable.Rows.Add("Sachin", "Singh", "PNP", "Vai", "Goa", 444056, 9856362563, "Sachin10@gmail.com");
        }
    }
}
