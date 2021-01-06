using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Xamarin.Forms;
using System.Linq;
using ToDoApp.ViewModels;


namespace ToDoApp
{
    public abstract class Bootstrapper
    {
        protected ContainerBuilder ContainerBuilder { get; private set; }
        public Bootstrapper()
        {
            Initialize();
            FinishInitialization();
        }
    }
}
