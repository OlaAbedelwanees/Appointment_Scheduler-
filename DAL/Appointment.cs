using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class Appointment
    {
        public long Id {get;set;}
        public DateTime Date {get;set;}
        public string Title {get;set;}
        public string Description {get;set;}
        public Guid UserId {get;set;}
        public virtual User User {get;set;}
    }
}