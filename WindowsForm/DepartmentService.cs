using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsForm
{
    internal class DepartmentService
    {
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            client.BaseAddress = new Uri("http://localhost:8080");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public List<Department> GetDepartmentList()
        {
            List<Department> list = null;
            HttpResponseMessage response = client.GetAsync("api/department").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                list = JsonSerializer.Deserialize<List<Department>>(resultString);
                return list;
            }
            return null;
        }

        public bool InsertDepartment(Department department)
        {
            
            string departmentJson = JsonSerializer.Serialize(department);
            StringContent content = new StringContent(departmentJson, Encoding.UTF8, "application/json");

            
            HttpResponseMessage response = client.PostAsync("api/department", content).Result;
            return response.IsSuccessStatusCode;
        }

        public bool UpdateDepartment(int departmentId, Department updatedDepartment)
        {
            // Verificăm dacă angajatul există înainte de a încerca actualizarea
            HttpResponseMessage checkResponse = client.GetAsync($"api/department/{departmentId}").Result;
            if (!checkResponse.IsSuccessStatusCode)
            {

                return false;
            }

            HttpResponseMessage getResponse = client.GetAsync($"api/department/{departmentId}").Result;
            if (getResponse.IsSuccessStatusCode)
            {
                string currentDepartmentJson = getResponse.Content.ReadAsStringAsync().Result;
                Department currentDepartment = JsonSerializer.Deserialize<Department>(currentDepartmentJson);


                if (!string.IsNullOrEmpty(updatedDepartment.description))
                {
                    currentDepartment.description = updatedDepartment.description;
                }
                if (updatedDepartment.managerID != 0)
                {
                    currentDepartment.managerID = updatedDepartment.managerID;
                }
                if (updatedDepartment.parentID != 0)
                {
                    currentDepartment.parentID = updatedDepartment.parentID;
                }

                string updatedDepartmentJson = JsonSerializer.Serialize(currentDepartment);
                StringContent content = new StringContent(updatedDepartmentJson, Encoding.UTF8, "application/json");


                HttpResponseMessage response = client.PutAsync($"api/department/{departmentId}", content).Result;
                return response.IsSuccessStatusCode;
            }

            return false;
        }

        public bool DeleteDepartment(int departmentId)
        {
            HttpResponseMessage response = client.GetAsync($"api/department/{departmentId}").Result;

            if (response.IsSuccessStatusCode)
            {
                HttpResponseMessage deleteResponse = client.DeleteAsync($"api/department/{departmentId}").Result;
                return deleteResponse.IsSuccessStatusCode;
            }
            else
            {

                return false;
            }
        }
    }
}
