﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RosSharp;

namespace Listener
{
    class Program
    {
        static void Main(string[] args)
        {
            ROS.Initialize(new Uri("http://192.168.11.4:11311/"), "192.168.11.3");

            var node = ROS.CreateNode();

            var subscriber = node.CreateSubscriber<RosSharp.StdMsgs.String>("chatter");

            subscriber.Subscribe(x => Console.WriteLine(x.data));

            Console.ReadKey();
        }
    }
}
