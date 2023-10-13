using CarWaybills.Scripts.Events;
using CarWaybills.Scripts.Services;
using DevExpress.Mvvm;
using System.Windows.Input;

namespace CarWaybills.ViewModels
{
    public class WaybillViewModel : BindableBase
    {
        private readonly PageService _pageService;
        private readonly EventBus _eventBus;
        private readonly MessageBus _messageBus;

        public WaybillViewModel(PageService pageService, EventBus eventBus, MessageBus messageBus)
        {
            _pageService = pageService;
            _eventBus = eventBus;
            _messageBus = messageBus;
        }

        //ОТКРЫТИЕ ОКНА
        //public ICommand ChangePage => new AsyncCommand(async () =>
        //{
        //    _pageService.ChangePage(new WaybillsPage());

        //    await _eventBus.Publish(new LeaveFromFirstPageEvent());
        //});

        //ПОСЛАТЬ СООБЩЕНИЕ СО СТРАНИЦЫ
        //public ICommand SendLog => new AsyncCommand(async () =>
        //{
        //       await _messageBus.SendTo<LogPageViewModel>(new TextMessage(LogText));
        //       //await _messageBus.SendTo<object>(new TextMessage(LogText));

        //});
    }
}
