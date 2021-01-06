using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Repositories;

namespace ToDoApp.ViewModels
{
    public class ItemViewModel : ViewModel
    {
        private TodoItemRepository repository;
        public ItemViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
        }
    }
}
