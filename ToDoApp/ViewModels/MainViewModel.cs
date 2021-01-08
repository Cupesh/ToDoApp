using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Repositories;
using System.Windows.Input;
using Xamarin.Forms;
using ToDoApp.Views;
using System.Collections.ObjectModel;
using System.Linq;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private readonly TodoItemRepository repository;
        public ObservableCollection<TodoItemViewModel> Items { get; set; }
        public ICommand AddItems => new Command(async () =>
        {
            var itemView = Resolver.Resolve<ItemView>();
            await Navigation.PushAsync(itemView);
        });

        public MainViewModel(TodoItemRepository repository)
        {
            repository.OnItemAdded += (sender, item) =>
            Items.Add(CreateTodoItemViewModel(item));
            repository.OnItemUpdated += (sender, item) => Task.Run(async () => await LoadData());

            this.repository = repository;
            Task.Run(async () => await LoadData());
        }

        private async Task LoadData()
        {
            var items = await repository.GetItems();
            var itemViewModels = items.Select(i => CreateTodoItemViewModel(i));
            Items = new ObservableCollection<TodoItemViewModel>(itemViewModels);
        }

        private TodoItemViewModel CreateTodoItemViewModel(TodoItem item)
        {
            var itemViewModel = new TodoItemViewModel(item);
            itemViewModel.ItemStatusChanged += ItemStatusChanged;
            return itemViewModel;
        }

        private void ItemStatusChanged(object sender, EventArgs e)
        {

        }
    }
}
