using Cms.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cms.Data
{
    public interface IEmployeeService
    {
        List<Employee> GetEmpoyees();
        List<EmployeeViewModel> SearchEmployees(string key);

    }
}
