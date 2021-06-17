﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web410828721_2_.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    public class StudentMetadata
    {

        public int id { get; set; }
           
        [Required(ErrorMessage = "請填寫姓名")]
        [Display(Name = "姓名")]
        [StringLength(5,MinimumLength =2, ErrorMessage ="請輸入2~5個字")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請填寫學號")]
        [Display(Name = "學號")]
        [StringLength(10,  ErrorMessage = "請輸入1~10個字")]
        public string Number { get; set; }

        [Required(ErrorMessage = "請填寫Email")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
