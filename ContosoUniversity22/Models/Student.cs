﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity22.Models {
    public class Student {
        public int ID { get; set; }
        [Required]
        [Display(Name="Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Display(Name="First Name")]
        [StringLength(50)]
       
        [Column("FirstName")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName {
            get { return LastName + " " + FirstMidName; }
        }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}