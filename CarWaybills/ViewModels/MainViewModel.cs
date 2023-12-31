﻿using CarWaybills.Scripts.Services;
using CarWaybills.Scripts.Services.Animations;
using DevExpress.Mvvm;
using System.Windows.Controls;
using System.Windows.Input;

namespace CarWaybills.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly PageService _pageService;

        public Page PageSource { get; set; }

       // public double FrameOpacity { get; set; }

        public MainViewModel(PageService pageService)
        {
            _pageService = pageService;


            _pageService.OnPageChanged += (page) => PageSource = page;
            _pageService.ChangePage(new CarsPage());
        }

        public ICommand bMenuCars_Click => new DelegateCommand(() =>
        {
            //PageAnimation.DescOpacity(FrameOpacity);
            _pageService.ChangePage(new CarsPage());
           // PageAnimation.IncOpacity(FrameOpacity);
        });

        public ICommand bMenuWaybills_Click => new DelegateCommand(() =>
        {
            //  PageAnimation.DescOpacity(FrameOpacity);
            _pageService.ChangePage(new WaybillsPage());
            // PageAnimation.IncOpacity(FrameOpacity);
        });

        //public ICommand bMenuCarsPage_Click
        //{
        //    get
        //    {
        //        return new RelayCommand(() => SlowOpacity(carsPage));
        //    }
        //}

        //public ICommand bMenuWaybillsPage_Click
        //{
        //    get
        //    {
        //        return new RelayCommand(() => SlowOpacity(waybillsPage));
        //    }
        //}

        //private async void SlowOpacity(Page page)
        //{
        //    await Task.Factory.StartNew(() =>
        //    {
        //        for (double i = 1.0; i > 0.0; i -= 0.1)
        //        {
        //            FrameOpacity = i;
        //            Thread.Sleep(50);
        //        }
        //        CurrentPage = page;
        //        for (double i = 0.0; i < 1.0; i += 0.1)
        //        {
        //            FrameOpacity = i;
        //            Thread.Sleep(50);
        //        }
        //    });
        //}
    }
}
