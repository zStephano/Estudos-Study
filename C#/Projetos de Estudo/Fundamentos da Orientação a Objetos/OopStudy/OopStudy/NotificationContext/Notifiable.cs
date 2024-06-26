using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStudy.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }
        
        public void Add(Notification notification)
        {
            Notifications.Add(notification); 
        }

        public void AddRamge(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}
