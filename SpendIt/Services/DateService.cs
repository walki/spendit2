using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpendIt.Services
{
    public class DateService : IDateService
    {
        public DateTime GetToday() => DateTime.Today;
    }
}
