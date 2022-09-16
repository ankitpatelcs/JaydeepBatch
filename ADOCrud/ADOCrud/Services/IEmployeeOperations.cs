﻿using ADOCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOCrud.Services
{
    public interface IEmployeeOperations
    {
        List<tblemployee> GetEmployees();
        tblemployee GetEmployeeById(int id);
        void AddEmployee(tblemployee obj);
        void UpdateEmployee(tblemployee obj);
        void DeleteEmployee(int id);

    }
}
