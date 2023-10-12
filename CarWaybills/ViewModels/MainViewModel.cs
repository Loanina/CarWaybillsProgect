using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CarWaybills.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private Page carsPage;
        private Page waybillsPage;

        private Page currentPage;
        public Page CurrentPage { 
            get { return currentPage; }
            set { 
                currentPage = value;
                RaisePropertyChanged(() => CurrentPage);
        }   }

        private double frameOpacity;
        public double FrameOpacity { get { return frameOpacity; } set { frameOpacity = value; RaisePropertyChanged(() => CurrentPage); } }


        public MainViewModel()
        {
            carsPage = new Page();
            waybillsPage = new Page();

            FrameOpacity = 1;
            CurrentPage = carsPage;
        }

        public ICommand bMenuCarsPage_Click
        {
            get
            {
                return new RelayCommand(() => SlowOpacity(carsPage));
            }
        }

        public ICommand bMenuWaybillsPage_Click
        {
            get
            {
                return new RelayCommand(() => SlowOpacity(waybillsPage));
            }
        }

        private async void SlowOpacity(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i>0.0; i -= 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
                CurrentPage = page;
                for (double i =0.0; i< 1.0; i += 0.1)
                {
                    FrameOpacity = i;
                    Thread.Sleep(50);
                }
            });
        }
    }
}
