﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class PushNotificationService : INotificationService
    {
       
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"notification to {recipient}\n message is : {message}\n done -_-");
        }
    }
}
