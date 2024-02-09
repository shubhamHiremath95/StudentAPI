﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentAPI.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("StudentName",TypeName ="varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Gender { get; set; }

        public int Age { get; set; }

        public int Stanadard { get; set; }
    }
}
