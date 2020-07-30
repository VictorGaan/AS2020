using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AtomSkills
{
    public class Manager
    {
        public static Frame MainFrame;
        public static AtomEntities context = new AtomEntities();
        public static Users user = null;
        public static string Title = string.Empty;
    }
}
