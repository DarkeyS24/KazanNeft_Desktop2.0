using KazanNeft.Database;
using KazanNeft.Models;
using KazanNeft_Desktop.Repositories.EmergencyMaintenanceRepository;
using KazanNeft_Desktop.Repositories.EmployeeRepository;
using KazanNeft_Desktop.Views;
using KazanNeft_Desktop.Views.EmployeeForms;

namespace KazanNeft_Destop
{
    public partial class LoginForm : Form
    {
        private EmployeeRepository db;
        private EmergencyMaintenanceRepository repository;
        public LoginForm()
        {
            InitializeComponent();
            db = new();
            repository = new();
        }
        private void OnCancelBtnClickedToClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnCheckedChangeToShowPassword(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                passwordTxt.PasswordChar = '\0';
            else
                passwordTxt.PasswordChar = '•';
        }
        private void OnOkBtnClickedToOtherForm(object sender, EventArgs e)
        {
            if (userTxt.Text == null && userTxt.Text == string.Empty)
            {
                MessageBox.Show("Write your username");
            }
            else if (passwordTxt.Text == null && passwordTxt.Text == string.Empty)
            {
                MessageBox.Show("Write your password");
            }
            else
            {
                Employee emp = db.IsEmployee(userTxt.Text, passwordTxt.Text);
                if (emp != null)
                {
                    if (emp.IsAdmin == 0)
                    {
                        MainUserForm userForm = new();
                        IList<MainUserForm.EmergencyDataTable> data = repository.getTableData(emp.Id);
                        userForm.setTable(data, emp);
                        userForm.Show();
                    }
                    else
                    {
                        MainEmployeeForm empForm = new();
                        empForm.Show();
                    }
                    
                }
            }
                

        }
    }
}
