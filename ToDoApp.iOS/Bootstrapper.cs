using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ToDoApp.iOS
{
    public class Bootstrapper : ToDoApp.Bootstrapper
    {
        public static void Init()
        {
            var instance = new Bootstrapper();
        }
    }
}