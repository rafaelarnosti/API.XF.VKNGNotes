using API.XF.VKNGNotes.Context;
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
        public List<Note> Get()
        {
            List<Note> notes;
            using (var context = new DBContext())
            {
                var selectNote = context.Set<Note>();
                notes = selectNote.ToList();
            }

            return notes;
        }

        // GET: api/Notes/5
        public Note Get(int id)
        {
            Note note;
            using (var context = new DBContext())
            {
                var selectNote = context.Set<Note>();
                note = selectNote.Where(x=>x.Id == id).FirstOrDefault();
            }

            return note;
        }

        // POST: api/Notes
        public void Post(Note note)
        {
            Note noteSelect;
            using (var context = new DBContext())
            {
                var selectNote = context.Set<Note>();
                noteSelect = selectNote.Where(x => x.Id == note.Id).FirstOrDefault();
                if (noteSelect == null)
                {
                    var addNote = context.Set<Note>();
                    addNote.Add(note);
                }
                else
                {
                    noteSelect.Titulo = note.Titulo;
                    noteSelect.Detalhes = note.Detalhes;
                    noteSelect.Latitude = note.Latitude;
                    noteSelect.Longitude = note.Longitude;
                    noteSelect.Senha = note.Senha;
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
        }

        // PUT: api/Notes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Notes/5
        public void Delete(int id)
        {
            Note note;
            using (var context = new DBContext())
            {
                var selectNote = context.Set<Note>();
                note = selectNote.Where(x => x.Id == id).FirstOrDefault();

                if(note != null)
                {
                    var delNote = context.Set<Note>();
                    delNote.Remove(note);
                    context.SaveChanges();
                }
            }
        }
    }
}
