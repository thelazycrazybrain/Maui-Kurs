using MvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.ViewModels {
    public class TodoListViewModel : ViewModelBase, IQueryAttributable {
        public TodoListViewModel()
        {
            AddTodoCommand = new Command(async () => {
               await Shell.Current.GoToAsync("/Detail");
            });

        }

        public void ApplyQueryAttributes(IDictionary<string, object> query) {
            if (query.TryGetValue("todo", out var todo) && todo is TodoModel t) {
                Todos.Add(t);
            }

        }
        private ObservableCollection<TodoModel> _todos = [];
        public ObservableCollection<TodoModel> Todos {
            get => _todos;
            set => SetPropertyValue(ref _todos, value);
        }


        private Command _addTodoCommand;
        public Command AddTodoCommand {
            get => _addTodoCommand;
            set => SetPropertyValue(ref _addTodoCommand, value);
        }

        
    }
}
