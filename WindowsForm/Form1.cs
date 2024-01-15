using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace WindowsForm
{
    public partial class Form1 : Form
    {

        EmployeeService employeeService;
        List<Employee> employeeList;

        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employeeService.createConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employeeList = employeeService.GetEmployeeList();
            comboBox1.DataSource = employeeList;
            comboBox1.DisplayMember = "Name";
        }

        public int GetManagerIdForDepartment(int departmentId)
        {
            string connectionString = "server=localhost;user=root;password=ADDcamera321!;database=departmentmanagement";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT managerId FROM Department WHERE departmentId = @DepartmentId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Eroare: " + ex.Message);
                        return -1;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        private void insert_button_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            newEmployee.name = textBoxName.Text;

            int departmentId;
            if (!int.TryParse(textBoxDepartmentId.Text, out departmentId))
            {
                MessageBox.Show("Introduceți un număr valid pentru departmentID.");
                return;
            }
            newEmployee.departmentID = departmentId;

            if (checkBoxIsManager.Checked)
            {
                checkBoxIsManager.Checked = true;
                int managerId = GetManagerIdForDepartment(departmentId);
                if (managerId == -1)
                {
                    MessageBox.Show("Nu s-a găsit managerID pentru departmentID-ul introdus.");
                    return;
                }
                newEmployee.managerID = managerId;
            }

            newEmployee.email = textBoxEmail.Text;


            bool insertionResult = employeeService.InsertEmployee(newEmployee);

            if (insertionResult)
            {
                textBoxDepartmentId.Text = "";
                textBoxEmail.Text = "";
                textBoxName.Text = "";
                checkBoxIsManager.Checked = false;

                MessageBox.Show("Inserare reusita in baza de date!");
            }
            else
            {
                MessageBox.Show("Inserare esuata in baza de date!");
            }
            RefreshEmployeeList();
        }


        private void delete_button_Click(object sender, EventArgs e)
        {
            int employeeIdToDelete;
            if (!int.TryParse(textBoxDeleteId.Text, out employeeIdToDelete))
            {
                MessageBox.Show("Introduceți un ID valid pentru ștergere.");
                return;
            }

            bool deletionResult = employeeService.DeleteEmployee(employeeIdToDelete);

            if (deletionResult)
            {
                MessageBox.Show("Ștergere reușită din baza de date!");
            }
            else
            {
                MessageBox.Show("Ștergere eșuată din baza de date - ID inexistent!");
            }

            textBoxDeleteId.Text = "";
            RefreshEmployeeList();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            int employeeIdToUpdate;
            if (!int.TryParse(textBoxUpdateId.Text, out employeeIdToUpdate))
            {
                MessageBox.Show("Introduceți un ID valid pentru actualizare.");
                return;
            }

            Employee updatedEmployee = new Employee();

            if (!string.IsNullOrEmpty(textBoxUpdatedName.Text))
            {
                updatedEmployee.name = textBoxUpdatedName.Text;
            }
            if (!string.IsNullOrEmpty(textBoxUpdatedEmail.Text))
            {
                updatedEmployee.email = textBoxUpdatedEmail.Text;
            }

            int departmentId;
            if (!string.IsNullOrEmpty(textBoxUpdatedDepartmentId.Text) && int.TryParse(textBoxUpdatedDepartmentId.Text, out departmentId))
            {

                int managerId = GetManagerIdForDepartment(departmentId);

                // Verificăm dacă angajatul este manager
                bool wasManager = managerId != 0;

                // Afisăm un mesaj către utilizator pentru a confirma dacă vrea să fie manager sau nu
                DialogResult result = MessageBox.Show("Doriți să fie manager?", "Confirmare", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Angajatul va deveni manager
                    if (managerId != -1)
                    {
                        updatedEmployee.departmentID = departmentId;
                        updatedEmployee.managerID = managerId;
                    }
                    else
                    {
                        MessageBox.Show("DepartmentID-ul introdus nu există în baza de date.");
                        return;
                    }
                }
                else
                {
                    // Angajatul nu va fi manager
                    updatedEmployee.departmentID = departmentId;
                    updatedEmployee.managerID = 0;
                    MessageBox.Show("Angajatul nu va fi manager. ManagerID-ul setat la 0.");
                }
            }
            bool updateResult = employeeService.UpdateEmployee(employeeIdToUpdate, updatedEmployee, this);

            if (updateResult)
            {
                MessageBox.Show("Actualizare reușită în baza de date!");
            }
            else
            {
                MessageBox.Show("Eroare la actualizare sau ID inexistent!");
            }


            textBoxUpdateId.Text = "";
            textBoxUpdatedName.Text = "";
            textBoxUpdatedEmail.Text = "";
            textBoxUpdatedDepartmentId.Text = "";

            RefreshEmployeeList();
        }

        private void RefreshEmployeeList()
        {
            employeeList = employeeService.GetEmployeeList();
            comboBox1.DataSource = employeeList;
            comboBox1.DisplayMember = "Name";
        }
    }
}