using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FightingClubWPF
{
    public class OutputConsole : TextWriter
    {
        private ListBox list;

        public OutputConsole(ListBox list)
        {
            this.list = list;
        }

        public override void Write(string value)
        {
            list.Items.Add(value);
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
