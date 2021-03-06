﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlockbusterMVC
{
    [MetadataType(typeof(Custmetadata))]
    public partial class Customer
    {
    }
    public class Custmetadata
    {
        public int CustomerID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
    
}