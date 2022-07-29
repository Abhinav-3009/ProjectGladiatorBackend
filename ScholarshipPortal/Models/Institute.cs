﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ScholarshipPortal.Models
{
    public partial class Institute
    {
        public Institute()
        {
            InstituteApprovals = new HashSet<InstituteApproval>();
            ScholarshipApplications = new HashSet<ScholarshipApplication>();
        }

        public int InstituteId { get; set; }
        public string InstituteCategory { get; set; }
        public string Name { get; set; }
        public int Institutecode { get; set; }
        public int Disecode { get; set; }
        public string Location { get; set; }
        public string InstituteType { get; set; }
        public string AffiliatedState { get; set; }
        public string AffiliatedName { get; set; }
        public string AdmissionStartYear { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public int Pincode { get; set; }
        public string PrincipalName { get; set; }
        public int PrincipalNumber { get; set; }

        public virtual ICollection<InstituteApproval> InstituteApprovals { get; set; }
        public virtual ICollection<ScholarshipApplication> ScholarshipApplications { get; set; }
    }
}
