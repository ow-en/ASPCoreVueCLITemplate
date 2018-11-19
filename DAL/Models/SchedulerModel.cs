using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    public class Scheduler
    {
        public int SchedulerId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public ICollection<Scheduler> Schedules { get; set; }
    }
}
