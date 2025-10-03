using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class Weather
    {
        public int Id { get; set; }

        public string MeasueredBy { get; set; } = string.Empty;

        public DateTime MeasueredDate { get; set;}
    }
}