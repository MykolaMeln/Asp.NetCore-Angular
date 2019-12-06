using Microsoft.AspNetCore.Mvc;
using Project.DAL.EF;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Project.Controllers
{
    [ApiController]
    [Route("api/prohrams")]
    public class CommentController : Controller
    {
        DBContext db;
        public CommentController(DBContext context)
        {
            db = context;
            if (!db.Comments.Any())
            {
                db.Comments.Add(new Comment { userid = "1", username = "admin", comment = "this is alreally cool", date = DateTime.Now });
                db.Comments.Add(new Comment { userid = "1", username = "admin" , comment = "I`m finished this project after one week", date = DateTime.Now });
                db.Comments.Add(new Comment { userid = "2", username  = "user", comment = "Hello! this program is`nt finish!", date = DateTime.Now });
                db.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return db.Comments.ToList();
        }

        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            Comment comment = db.Comments.FirstOrDefault(x => x.commentid == id);
            return comment;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Add(comment);
                db.SaveChanges();
                return Ok(comment);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody]Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Update(comment);
                db.SaveChanges();
                return Ok(comment);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Comment comment = db.Comments.FirstOrDefault(x => x.commentid == id);
            if (comment != null)
            {
                db.Comments.Remove(comment);
                db.SaveChanges();
            }
            return Ok(comment);
        }
    }
}
