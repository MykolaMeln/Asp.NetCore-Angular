using Microsoft.AspNetCore.Mvc;
using Project.DAL.EF;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/radios")]
    public class RadioController : Controller
    {
        DBContext db;
        public RadioController(DBContext context)
        {
            db = context;
            if (!db.Radio_Stations.Any())
            {
                db.Radio_Stations.Add(new Radio { Name = "Radiopepper", Frequency = 120, Rating = 20 });
                db.Radio_Stations.Add(new Radio { Name = "Bukovyna", Frequency = 80, Rating = 15 });
                db.Radio_Stations.Add(new Radio { Name = "Starradio", Frequency = 89, Rating = 25 });
                db.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Radio> Get()
        {
            return db.Radio_Stations.ToList();
        }

        [HttpGet("{id}")]
        public Radio Get(int id)
        {
            Radio radio = db.Radio_Stations.FirstOrDefault(x => x.RadioId == id);
            return radio;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Radio radio)
        {
            if (ModelState.IsValid)
            {
                db.Radio_Stations.Add(radio);
                db.SaveChanges();
                return Ok(radio);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody]Radio radio)
        {
            if (ModelState.IsValid)
            {
                db.Update(radio);
                db.SaveChanges();
                return Ok(radio);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Radio radio = db.Radio_Stations.FirstOrDefault(x => x.RadioId == id);
            if (radio != null)
            {
                db.Radio_Stations.Remove(radio);
                db.SaveChanges();
            }
            return Ok(radio);
        }
    }
}
