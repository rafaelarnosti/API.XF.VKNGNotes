﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.XF.VKNGNotes.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}