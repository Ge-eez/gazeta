using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MClass
{
    public class PostPublisher
    {
        public event EventHandler NewPostCreated; 

        public void SendNotification()
        {
            OnNewPostCreated();
        }

        public virtual void OnNewPostCreated()
        {
            if (NewPostCreated != null) NewPostCreated(this, EventArgs.Empty);
        }
    }
}
