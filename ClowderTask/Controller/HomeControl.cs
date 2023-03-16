using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClowderTask.View;
using ClowderTask.View.Interfaces;
using System.Windows.Forms;



namespace ClowderTask.Controller
{
    class HomeControl
    {
        private readonly IHomeView _view;

        public HomeControl(IHomeView view)
        {
            _view = view;

            _view.TaskButtonClick += OnTaskButtonClick;
            _view.ShopButtonClick += OnShopButtonClick;
            _view.SettingsButtonClick += OnSettingsButtonClick;
        }

        public void OnTaskButtonClick(object sender, EventArgs e)
        {
            _view.OpenTaskScreen();
            
        }


        public void OnShopButtonClick(object sender, EventArgs e)
        {
            _view.OpenShopScreen();

        }


        public void OnSettingsButtonClick(object sender, EventArgs e)
        {
            _view.OpenSettingsScreen();

        }

        public void OpenSettingsScreen()
        {
            Application.Run(new SettingsView());
        }

        public void OpenShopScreen()
        {
            Application.Run(new ShopView());
        }

        public void OpenTaskScreen()
        {
            Application.Run(new TaskView());
        }

        // CatClick() should have a small reaction from the cat upon clicking to add to interactivity
        void CatClick()
        {

        }
    }
}
