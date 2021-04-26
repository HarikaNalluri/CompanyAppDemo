using Cms.Data.DataModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cms.Data
{

    public class EmployeesService: IEmployeeService
    {
        private CompanyContext CompanyContext { get; set; }
        public EmployeesService(CompanyContext companyContext)
        {
            this.CompanyContext = companyContext;
            //this.CompanyContext = new CompanyContext();
        }

        public List<Employee> GetEmpoyees()
        {
            return this.CompanyContext.Employees.Where(c => !c.Deleted).ToList();
        }       

        public List<EmployeeViewModel> SearchEmployees(string key)
        {
           var param = new SqlParameter[] {
               new SqlParameter()
           {
               ParameterName = "@Key",
               SqlDbType = System.Data.SqlDbType.VarChar,
               Size = 50,
               Direction = System.Data.ParameterDirection.Input,
               Value = string.IsNullOrEmpty(key) ? (object)DBNull.Value: key
           }};
            return this.CompanyContext.EmployeeViewModel.FromSqlRaw("[dbo].[EmployeeDetails] @Key", param).ToList();
        }
    }
}
