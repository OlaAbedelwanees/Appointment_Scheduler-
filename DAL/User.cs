using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        public Guid Id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Email {get;set;}
        public int Mobile {get; set;}
        public string Password {get;set;}
        public virtual List<Appointment> Appointments {get; set;}
    } 
}