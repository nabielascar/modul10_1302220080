using Microsoft.AspNetCore.Mvc;

namespace modul10_1302220080.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<String> course = new List<String> { "PBO", "KPL", "BD", "UX" };
        private static List<Mahasiswa> arrMahasiswa = new List<Mahasiswa>
        {
        new Mahasiswa ("Nabiel Ascar Mochammad", "1302220080",course, 2022),
        new Mahasiswa("Fauzan Arrizqy Putra", "1302220004", course, 2023),
        new Mahasiswa("Muhammad Izhar Fahriansyah", "1302220056", course, 2021),
        new Mahasiswa("Wildan Hadi Fernando", "1302223012", course, 2020)
        };
        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return arrMahasiswa;
        }

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            return arrMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody]Mahasiswa mahasiswa)
        {
            arrMahasiswa.Add(mahasiswa);
           
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            arrMahasiswa.RemoveAt(id);
        }
    }
}
