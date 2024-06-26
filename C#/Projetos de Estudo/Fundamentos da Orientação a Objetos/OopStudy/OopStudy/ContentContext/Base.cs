using OopStudy.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStudy.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
