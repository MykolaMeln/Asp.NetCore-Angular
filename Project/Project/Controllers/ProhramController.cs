using Microsoft.AspNetCore.Mvc;
using Project.DAL.EF;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Project.Controllers
{
    [Route("api/prohrams")]
    public class ProhramController : Controller
    {
        DBContext db;
        public ProhramController(DBContext context)
        {
            db = context;
            if (!db.Prohrams.Any())
            {
                db.Prohrams.Add(new Prohram { radioid= 1, Name_program = "Hity 90-x", Period = "Sat-Sun", Hour_begin = "06:00:00", Hour_end="10:00:00" });
                db.Prohrams.Add(new Prohram { radioid = 1, Name_program = "Interview", Period = "Mon-Fri", Hour_begin = "11:30:00", Hour_end = "13:30:00" });
                db.Prohrams.Add(new Prohram { radioid = 2, Name_program = "Gosti", Period = "Sat-Sun", Hour_begin = "10:10:00", Hour_end = "13:00:00" });
                db.Prohrams.Add(new Prohram { radioid = 2, Name_program = "Top 10", Period = "Mon-Fri", Hour_begin = "13:40:00", Hour_end = "14:50:00" });
                db.Prohrams.Add(new Prohram { radioid = 3, Name_program = "Vechirni rozmovy", Period = "Sat-Sun", Hour_begin = "18:00:00", Hour_end = "20:00:00" });
                db.Prohrams.Add(new Prohram { radioid = 3, Name_program = "Relax", Period = "Mon-Fri", Hour_begin = "17:00:00", Hour_end = "19:30:00" });
                db.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Prohram> Get()
        {
            return db.Prohrams.ToList();
        }

        [HttpGet("{id}")]
        public Prohram Get(int id)
        {
            Prohram prohram = db.Prohrams.FirstOrDefault(x => x.ProgramId == id);
            return prohram;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Prohram prohram)
        {
            if (ModelState.IsValid)
            {
                db.Prohrams.Add(prohram);
                db.SaveChanges();
                return Ok(prohram);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody]Prohram prohram)
        {
            if (ModelState.IsValid)
            {
                db.Update(prohram);
                db.SaveChanges();
                return Ok(prohram);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Prohram prohram = db.Prohrams.FirstOrDefault(x => x.ProgramId == id);
            if (prohram != null)
            {
                db.Prohrams.Remove(prohram);
                db.SaveChanges();
            }
            return Ok(prohram);
        }
    }
}
