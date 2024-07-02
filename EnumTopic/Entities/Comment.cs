using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnumTopic.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
