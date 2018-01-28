using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.XF.VKNGNotes.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Detalhes { get; set; }
        public Single Latitude { get; set; }
        public Single Longitude { get; set; }
        public string Senha { get; set; }
        public int? UserId { get; set; }

    }
}