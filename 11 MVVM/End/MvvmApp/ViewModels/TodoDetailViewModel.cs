using MvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.ViewModels {
    public class TodoDetailViewModel : ViewModelBase {
        public TodoDetailViewModel() {
            Model = new TodoModel();

            SaveCommand = new Command(async () =>
                await Shell.Current.GoToAsync("..", new Dictionary<string, object>()
                {
                    {"todo", Model }
                })
            );

            CancelCommand = new Command(async () =>
                await Shell.Current.GoToAsync("..", new Dictionary<string, object> {
                { "todo", null }
                })
            );

        }

        public TodoModel Model { get; set; }


        private Command _saveCommand;
        public Command SaveCommand {
            get => _saveCommand;
            set => SetPropertyValue(ref _saveCommand, value);
        }


        private Command _cancelCommand;
        public Command CancelCommand {
            get => _cancelCommand;
            set => SetPropertyValue(ref _cancelCommand, value);
        }


    }
}
