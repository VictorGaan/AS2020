using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomSkillsWeb
{
    public class Manager
    {
        public static AtomEntities context = new AtomEntities();
        public static Users user = null;
    }
}