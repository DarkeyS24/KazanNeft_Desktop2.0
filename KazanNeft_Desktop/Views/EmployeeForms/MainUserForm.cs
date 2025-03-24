using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KazanNeft.Database;
using KazanNeft.Models;
using KazanNeft_Desktop.Repositories.AssetsRepository;
using KazanNeft_Desktop.Repositories.EmergencyMaintenanceRepository;
using KazanNeft_Desktop.Repositories.PriorityRepository;
using KazanNeft_Desktop.Views.EmployeeForms;

namespace KazanNeft_Desktop.Views
{
    public partial class MainUserForm : Form
    {
        private Employee employee;
        private EmergencyDataTable emergency;
        private PriorityRepository priority;
        private AssetRepository asset;
        public MainUserForm()
        {
            InitializeComponent();
            employee = new();
            emergency = new();
            priority = new();
            asset = new();
        }

        public class EmergencyDataTable
        {
            public string AssetSN { get; set; } = string.Empty;
            public string AssetName { get; set; } = string.Empty;
            public DateOnly? LastClosedEM { get; set; }
            public int NumberOfEMs { get; set; }
        }
        public void SetTable(IList<EmergencyDataTable> data, Employee emp)
        {
            this.employee = emp;
            emergencyTable.DataSource = data;
        }
        private void EmergencyTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int row = e.RowIndex;
                string data = emergencyTable.Rows[row].Cells["LastClosedEM"].Value.ToString();
                emergency.AssetSN = emergencyTable.Rows[row].Cells["AssetSN"].Value.ToString();
                emergency.AssetName = emergencyTable.Rows[row].Cells["AssetName"].Value.ToString();
                emergency.LastClosedEM = DateOnly.Parse(data);
                emergency.NumberOfEMs = int.Parse(emergencyTable.Rows[row].Cells["NumberOfEMs"].Value.ToString());
            }
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
    }
}
