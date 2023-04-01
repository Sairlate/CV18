using CV18.Infrastructure.Comments;
using CV18.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;


namespace CV18.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _Title = "Анализ статистики CV18";

        public string Title
        {
            get => _Title;
            //set
            //{
            //    //if (Equals(_Title, value)) return;
            //    //_Title = value;
            //    //OnPropertyChanged();

            //    Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status: string - Статус программы
        ///<summary>Статус программы</summary>
        private string _Status = "Готов!";

        public string Status 
        { 
            get => _Status; 
            set => Set(ref _Status, value); 
        }

        #endregion

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationComand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #endregion


        public MainWindowViewModel()
        {
            #region Команды
            CloseApplicationComand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            #endregion
        }
    }

}
