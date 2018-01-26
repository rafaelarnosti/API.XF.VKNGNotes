using API.XF.VKNGNotes.Context;
using API.XF.VKNGNotes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.XF.VKNGNotes.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/User
        public List<User> Get()
        {
            List<User> users;
            using (var context = new DBContext())
            {
                var selectNote = context.Set<User>();
                users = selectNote.ToList();
            }

            return users;
        }

        // GET: api/User/5
        public User Get(int id)
        {
            User user;
            using (var context = new DBContext())
            {
                var selectNote = context.Set<User>();
                user = selectNote.Where(x => x.Id == id).FirstOrDefault();
            }

            return user;
        }

        // POST: api/User
        public void Post(User user)
        {
            using (var context = new DBContext())
            {
                var addNote = context.Set<User>();
                addNote.Add(user);

                context.SaveChanges();
            }
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
