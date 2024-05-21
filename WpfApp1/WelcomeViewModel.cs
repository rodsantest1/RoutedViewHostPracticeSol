using ReactiveUI;

namespace WpfApp1
{
    public class WelcomeViewModel : ReactiveObject, IWelcomeViewModel
    {
        public IScreen HostScreen { get; protected set; }

        string IRoutableViewModel.UrlPathSegment => "welcome";

        public WelcomeViewModel(IScreen screen)
        {
            HostScreen = screen;
        }
    }

    public interface IWelcomeViewModel : IRoutableViewModel
    {

    }
}
