using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWaybills.Scripts
{
    class EntryPoint
    {
        private CarsPage carsPage;
        public CarsPage CarsPage { get { return carsPage; } }
        private WaybillsPage waybillsPage;
        public WaybillsPage WaybillsPage {  get { return waybillsPage; } }


        public void LoadAll()
        {
            LoadPages();
        }

        private void LoadPages()
        {
            carsPage = new CarsPage();
            waybillsPage = new WaybillsPage();
        }
    }
}
