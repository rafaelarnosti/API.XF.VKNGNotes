using API.XF.VKNGNotes.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.XF.VKNGNotes.Controllers
{
    public class NotesController : ApiController
    {
        // GET: api/Notes
        public Notes[] Get()
        {
            Notes[] notes;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new
                    Uri("https://vkngnotes.azurewebsites.net");

                var json = client.GetStringAsync("/").Result;
                 notes = JsonConvert.DeserializeObject<Notes[]>(json);
            }

            return notes;
        }

        // GET: api/Notes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Notes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Notes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Notes/5
        public void Delete(int id)
        {
        }
    }
}
