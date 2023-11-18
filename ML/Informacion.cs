using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Informacion
    {
        public List<People> People { get; set; }

        public List<Inscriptions> Inscriptions { get; set; }
    }

    public class People
    {
        public string Name { get; set; }

        public string LastName { get; set; }
    }

    public class Inscriptions
    {
        public int CourseId { get; set; }

        public DateTime InscripcionDate { get; set; }

        public DateTime CertificationDate { get; set; }

        public int Advance { get; set; }

        public decimal ScoreCourse { get; set; }

        public string FolioCertificate { get; set; }

        public bool AnyTest { get; set; }

        public Course Course { get; set; }
    }

    public class Course
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public Sector Sector { get; set; }
    }

    public class Sector
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ColorTheme { get; set; }
    }
}
