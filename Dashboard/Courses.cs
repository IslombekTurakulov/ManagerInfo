using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;

namespace Dashboard
{
    public class Courses
    {
        public int Rank { get; set; }
        public string CourseTitle { get; set; }
        public string Organization { get; set; }
        public string CertificateType { get; set; }
        public double Rating { get; set; }
        public string Difficulty { get; set; }
        public string StudentsAmount { get; set; }
    }
}
