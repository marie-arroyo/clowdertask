using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// interface for home view that declares some methods and events interface
namespace ClowderTask.View.Interfaces
{
    public interface IHomeView
    {
        // show home view
        void Show();

        //close home view
        void Close();

        
        event EventHandler TaskButtonClick;

        event EventHandler ShopButtonClick;

        event EventHandler SettingsButtonClick;

        void OpenSettingsScreen();
        void OpenTaskScreen();
        void OpenShopScreen();


    }
}
