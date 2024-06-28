using OopStudy.ContentContext.Enums;
using OopStudy.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStudy.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
