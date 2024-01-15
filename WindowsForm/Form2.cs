using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForm
{
    public partial class Form2 : Form
    {
        DepartmentService departmentService;
        List<Department> departmentList;
        EmployeeService employeeService;
        List<Employee> employeeList;

        public Form2()
        {
            InitializeComponent();
            departmentService = new DepartmentService();
            departmentService.createConnection();
            employeeService = new EmployeeService();
            employeeService.createConnection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            Department newDepartment = new Department();
            newDepartment.description = textBoxDescription.Text;

            int managerId;
            if (!int.TryParse(textBoxManagerId.Text, out managerId))
            {
                MessageBox.Show("Introduceți un număr valid pentru managerID.");
                return;
            }
            newDepartment.managerID = managerId;

            int parentId;
            if (!int.TryParse(textBoxParentId.Text, out parentId))
            {
                MessageBox.Show("Introduceți un număr valid pentru parentID.");
                return;
            }
            newDepartment.parentID = parentId;

            bool insertionResult = departmentService.InsertDepartment(newDepartment);

            if (insertionResult)
            {
                textBoxDescription.Text = "";
                textBoxManagerId.Text = "";
                textBoxParentId.Text = "";

                MessageBox.Show("Inserare departamentului s-a realizat cu succes!");
            }
            else
            {
                MessageBox.Show("Inserarea departamentului a eșuat!");
            }
            RefreshDepartmentList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            var departmentList = departmentService.GetDepartmentList();

            comboBox1.DataSource = departmentList;
            comboBox1.DisplayMember = "Description";
        }

        private void update_button_Click(object sender, EventArgs e)
        {

            int departmentIdToUpdate;
            if (!int.TryParse(textBoxUpdateId.Text, out departmentIdToUpdate))
            {
                MessageBox.Show("Introduceți un ID valid pentru actualizare.");
                return;
            }

            Department updatedDepartment = new Department();



            if (!string.IsNullOrEmpty(textBoxUpdatedDescription.Text))
            {
                updatedDepartment.description = textBoxUpdatedDescription.Text;
            }
            int managerId;
            if (!string.IsNullOrEmpty(textBoxUpdatedManagerId.Text) && int.TryParse(textBoxUpdatedManagerId.Text, out managerId))
            {
                updatedDepartment.managerID = managerId;
            }
            int parentId;
            if (!string.IsNullOrEmpty(textBoxUpdatedParentId.Text) && int.TryParse(textBoxUpdatedParentId.Text, out parentId))
            {
                updatedDepartment.parentID = parentId;
            }

            bool updateResult = departmentService.UpdateDepartment(departmentIdToUpdate, updatedDepartment);

            if (updateResult)
            {
                MessageBox.Show("Actualizare reușită în baza de date!");
            }
            else
            {
                MessageBox.Show("Eroare la actualizare sau ID inexistent!");
            }


            textBoxUpdateId.Text = "";
            textBoxUpdatedDescription.Text = "";
            textBoxUpdatedManagerId.Text = "";
            textBoxUpdatedParentId.Text = "";

            RefreshDepartmentList();

        }
      

         private void delete_button_Click(object sender, EventArgs e)
         {

                 int departmentIdToDelete;
                 if (!int.TryParse(textBoxDeleteId.Text, out departmentIdToDelete))
                 {
                     MessageBox.Show("Introduceți un ID valid pentru ștergere.");
                     return;
                 }

                 bool deletionResult = departmentService.DeleteDepartment(departmentIdToDelete);

                 if (deletionResult)
                 {
                     MessageBox.Show("Ștergere angajatului s-a realizat cu succes!");
                 }
                 else
                 {
                     MessageBox.Show("Ștergerea a eșuat - ID inexistent!");
                 }

                 textBoxDeleteId.Text = "";
                 RefreshDepartmentList();
         }
        private void RefreshDepartmentList()
        {
            departmentList = departmentService.GetDepartmentList();
            comboBox1.DataSource = departmentList;
            comboBox1.DisplayMember = "Name";
        }

        private void RefreshEmployeeList()
        {
            employeeList = employeeService.GetEmployeeList();
            comboBox1.DataSource = employeeList;
            comboBox1.DisplayMember = "Name";
        }
    }
}
