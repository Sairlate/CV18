using CV18.Infrastructure.Comments.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace CV18.Infrastructure.Comments
{
    class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();

    }
}
