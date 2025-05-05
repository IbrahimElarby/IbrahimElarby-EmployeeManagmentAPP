using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.DAL
{
    public interface ISeeder
    {
        void Seed(ModelBuilder modelBuilder);
    }
}
