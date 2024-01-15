using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace WindowsForm
{
    internal class EmployeeService
    {
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8080");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public List<Employee> GetEmployeeList()
        {
            List<Employee> list = null;
            HttpResponseMessage response = client.GetAsync("/api/employee").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                list = JsonSerializer.Deserialize<List<Employee>>(resultString);
                return list;
            }
            return null;
        }

        public bool InsertEmployee(Employee employee)
        {
            // Convertim angajatul în format JSON
            string employeeJson = JsonSerializer.Serialize(employee);
            StringContent content = new StringContent(employeeJson, Encoding.UTF8, "application/json");

            // Trimitem cererea POST pentru a adăuga un angajat nou
            HttpResponseMessage response = client.PostAsync("api/employee", content).Result;
            return response.IsSuccessStatusCode;
        }
        public bool DeleteEmployee(int employeeId)
        {
            HttpResponseMessage response = client.GetAsync($"api/employee/{employeeId}").Result;

            if (response.IsSuccessStatusCode)
            {
                HttpResponseMessage deleteResponse = client.DeleteAsync($"api/employee/{employeeId}").Result;
                return deleteResponse.IsSuccessStatusCode;
            }
            else
            {

                return false;
            }
        }

        public bool UpdateEmployee(int employeeId, Employee updatedEmployee, Form1 form)
        {
            // Verificăm dacă angajatul există înainte de a încerca actualizarea
            HttpResponseMessage checkResponse = client.GetAsync($"api/employee/{employeeId}").Result;
            if (!checkResponse.IsSuccessStatusCode)
            {

                return false;
            }

            HttpResponseMessage getResponse = client.GetAsync($"api/employee/{employeeId}").Result;
            if (getResponse.IsSuccessStatusCode)
            {
                string currentEmployeeJson = getResponse.Content.ReadAsStringAsync().Result;
                Employee currentEmployee = JsonSerializer.Deserialize<Employee>(currentEmployeeJson);


                if (!string.IsNullOrEmpty(updatedEmployee.name))
                {
                    currentEmployee.name = updatedEmployee.name;
                }
                if (!string.IsNullOrEmpty(updatedEmployee.email))
                {
                    currentEmployee.email = updatedEmployee.email;
                }

                if (updatedEmployee.departmentID != 0)
                {
                    currentEmployee.departmentID = updatedEmployee.departmentID;
                    if (updatedEmployee.managerID != 0)
                    {
                        int managerId = form.GetManagerIdForDepartment(updatedEmployee.departmentID);
                        if (managerId != -1)
                        {
                            currentEmployee.managerID = managerId;
                        }
                       
                    }
                    else
                    {
                        currentEmployee.managerID = 0;
                    }
                }

                string updatedEmployeeJson = JsonSerializer.Serialize(currentEmployee);
                StringContent content = new StringContent(updatedEmployeeJson, Encoding.UTF8, "application/json");


                HttpResponseMessage response = client.PutAsync($"api/employee/{employeeId}", content).Result;
                return response.IsSuccessStatusCode;
            }

            return false;
        }

    }

}