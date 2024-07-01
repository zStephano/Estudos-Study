using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopStudy.NotificationContext;

namespace OopStudy.ContentContext
{
    public class Article : Content
    {
        public  IList<Notification> Notifications { get; set; }
        public Article (string title, string content) 
            :base(title, content)
        {

        }
    }
}
