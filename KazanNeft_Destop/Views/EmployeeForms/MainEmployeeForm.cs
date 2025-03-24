using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KazanNeft.Models;
using static KazanNeft_Desktop.Views.MainUserForm;

namespace KazanNeft_Desktop.Views.EmployeeForms
{
    public partial class MainEmployeeForm: Form
    {
        private Employee employee;
        public MainEmployeeForm()
        {
            InitializeComponent();
            employee = new();
        }
        public void setTable(IList<EmergencyDataTable> data, Employee emp)
        {
            this.employee = emp;
            emergencyTable.DataSource = data;
        }
    }
}
