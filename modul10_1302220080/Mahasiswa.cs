namespace modul10_1302220080
{
    public class Mahasiswa
    {
        public String name { get; set; }
        public String nim { get; set; }
        public List<String> course { get; set; }
        public int year { get; set; }
        public Mahasiswa(String name, String nim, List<String> course,  int year)
        {
            this.name = name;
            this.nim = nim;
            this.course = course;
            this.year = year;
        }

    }
}
