using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStudy.ContentContext
{
    public class Article : Content
    {
        public Article (string title, string content) 
            :base(title, content)
        {

        }
    }
}
