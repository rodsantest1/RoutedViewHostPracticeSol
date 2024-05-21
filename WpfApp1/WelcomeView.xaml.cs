﻿using ReactiveUI;
using System.Windows;

namespace WpfApp1
{

    public partial class WelcomeView : IViewFor<IWelcomeViewModel>
    {
        public WelcomeView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                //d(this.WhenAnyValue(x => x.ViewModel).BindTo(this, x => x.DataContext));
                //d(this.BindCommand(ViewModel, vm => vm.HelloWorld, view => view.helloWorldButton));
                //d(this.BindCommand(ViewModel, vm => vm.NavigateToSecond, view => view.navigateButton));
            });
        }

        public IWelcomeViewModel ViewModel
        {
            get { return (IWelcomeViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(IWelcomeViewModel), typeof(WelcomeView), new PropertyMetadata(null));

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IWelcomeViewModel)value; }
        }
    }
}
