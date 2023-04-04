﻿using CV18.Infrastructure.Comments;
using CV18.Models;
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
        #region TestDataPoints : IEnumerable<DataPoint> - Тестовый набор данных для визуализации графиков

        /// <summary> Тестовый набор данных для визуализации графиков </summary>
        private IEnumerable<DataPoint> _TestDataPoints;

        /// <summary> Тестовый набор данных для визуализации графиков </summary>
        public IEnumerable<DataPoint> TestDataPoints 
        { 
            get => _TestDataPoints; 
            set => Set(ref _TestDataPoints, value);      
        }

        #endregion
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

            var data_points = new List<DataPoint>((int)(360 / 0.1)); 
            for(var x = 0d; x <= 360; x += 0.1)
            {
                const double to_rad = Math.PI / 180;
                var y = Math.Sin(x * to_rad);

                data_points.Add(new DataPoint { XValue = x, YValue = y});
            }

            TestDataPoints = data_points;
        }
    }

}
