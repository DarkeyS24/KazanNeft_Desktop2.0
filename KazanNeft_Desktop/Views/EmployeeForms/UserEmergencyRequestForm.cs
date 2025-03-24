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
using KazanNeft_Desktop.Repositories.DepartmentLocationRepository;
using KazanNeft_Desktop.Repositories.DepartmentRepository;

namespace KazanNeft_Desktop.Views.EmployeeForms
{
    public partial class UserEmergencyRequestForm : Form
    {
        private Employee employee;    
        
        public UserEmergencyRequestForm()
        {
            InitializeComponent();
            employee = new();
        }

        public void SetDataValues(Asset asset, Employee employee, MainUserForm.EmergencyDataTable emergency)
        {
            this.employee = employee;
            assetNameTxt.Text = asset.AssetName;
            serialTxt.Text = asset.AssetSN;
            departmentTxt.Text = GetDepartmentBySN(asset.DepartmentLocationId);
        }
        public void SetPriorityValues(IList<Priority> priorities)
        {
            foreach (Priority name in priorities)
            {
                priorityCb.Items.Add(name.Name);
            }
        }
        private string GetDepartmentBySN(int id)
        {
            DepartmentLocationRepository depLocationRep = new();
            DepartmentRepository departmentRep = new();
            var departmentLocation = depLocationRep.GetDepartmentById(id);
            var department = departmentRep.GetDepartmentById(id);
            return department.Name;
        }
    }
}
