using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }

        public string Name { get; set; }
        public string Code { get; set; }

        public int SchedulerId { get; set; }
        public Scheduler Scheduler { get; set; }
    }
}
