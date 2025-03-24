using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using KazanNeft.Models;
using KazanNeft_Desktop.Repositories.AssetsRepository;
using KazanNeft_Desktop.Repositories.PriorityRepository;
using static KazanNeft_Desktop.Views.MainUserForm;

namespace KazanNeft_Desktop.Views.EmployeeForms
{
    public partial class MainEmployeeForm : Form
    {
        private Employee employee;
        private EmergencyDataTable emergency;
        private PriorityRepository priority;
        private AssetRepository asset;
        public MainEmployeeForm()
        {
            InitializeComponent();
            employee = new();
            emergency = new();
            priority = new();
            asset = new();
        }
        public void SetTable(IList<EmergencyDataTable> data, Employee emp)
        {
            this.employee = emp;
            emergencyTable.DataSource = data;
        }
        private void RequestBtn_Click(object sender, EventArgs e)
        {
            var assetObj = asset.GetAssetBySerialNumber(emergency.AssetSN);
            var priorotyObj = priority.GetAllPriorities();
            UserEmergencyRequestForm requestForm = new UserEmergencyRequestForm();
            requestForm.SetDataValues(assetObj, employee, emergency);
            requestForm.SetPriorityValues(priorotyObj);
            requestForm.Show();
        }
        private void EmergencyTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int row = e.RowIndex;
                string data = emergencyTable.Rows[row].Cells["LastClosedEM"].Value.ToString();

                emergency.AssetSN = emergencyTable.Rows[row].Cells["AssetSN"].Value.ToString();
                emergency.AssetName = emergencyTable.Rows[row].Cells["AssetName"].Value.ToString();
                emergency.LastClosedEM = DateOnly.Parse(data);
                emergency.NumberOfEMs = int.Parse(emergencyTable.Rows[row].Cells["NumberOfEMs"].Value.ToString());
            }
        }
    }
}
