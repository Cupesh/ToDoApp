using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Repositories;
using System.Windows.Input;
using ToDoApp.Models;
using Xamarin.Forms;

namespace ToDoApp.ViewModels
{
    public class ItemViewModel : ViewModel
    {
        private TodoItemRepository repository;
        public TodoItem Item { get; set; }
        public ItemViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
            Item = new TodoItem() { Due = DateTime.Now.AddDays(1) };
        }

        public ICommand Save => new Command(async () =>
        {
            await repository.AddOrUpdate(Item);
            await Navigation.PushAsync();
        });
    }
}
