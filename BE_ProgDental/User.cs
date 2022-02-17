﻿using System.Collections.Generic;
namespace BE_ProgDental
{
    public class User
    {
        public User()
        {
            this.Visits = new HashSet<Visit>();
        }
        public int CodeMelli { get; set; }
        public string Name { get; set; }
        public string TimeEnter { get; set; }
        public string Tahsilat { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Moaref { get; set; }
        public string Jop { get; set; }
        public string GroupBload { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
