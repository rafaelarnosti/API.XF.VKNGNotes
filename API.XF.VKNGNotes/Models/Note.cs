using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.XF.VKNGNotes.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Detalhes { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}