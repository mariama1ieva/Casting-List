using List.Tasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Tasks.Services.Interface
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
      
        List<Employee> GetEmployess(DateTime startDate, DateTime endDate,Decimal salary);
    }
}
