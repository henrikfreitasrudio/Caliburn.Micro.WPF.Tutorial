using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Caliburn.Micro.WPF.Tutorial.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        protected async override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await EditCategories();
        }

        public async Task EditCategories()
        {
            var viewmodel = IoC.Get<CategoryViewModel>();
            await ActivateItemAsync(viewmodel, new CancellationToken());
        }

        public bool CanFileMenu
        {
            get
            {
                return false;
            }
        }

        private readonly IWindowManager _windowManager;

        public ShellViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public Task About()
        {
            return _windowManager.ShowDialogAsync(IoC.Get<AboutViewModel>());
        }
    }
}
