﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [Phone]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }
        public int? AddressId { get; set; }
        public string Code { get; set; }

        public AddressModel Address { get; set; }

       
    }
}
