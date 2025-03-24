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
using KazanNeft_Desktop.Repositories.EmergencyMaintenanceRepository;

namespace KazanNeft_Desktop.Views
{
    public partial class MainUserForm: Form
    {
        private EmergencyMaintenanceRepository repository;
        private Employee employee;
        public MainUserForm()
        {
            InitializeComponent();
            repository = new();
        }

        public class EmergencyDataTable
        {
            public string AssetSN { get; set; } = string.Empty;
            public string AssetName { get; set; } = string.Empty;
            public DateOnly LastClosedEM { get; set; }
            public int NumberOfEMs { get; set; }
        }

        public void setTable(IList<EmergencyDataTable> data, Employee emp)
        {
            this.employee = emp;
            emergencyTable.DataSource = data;
        }   
    }
}
