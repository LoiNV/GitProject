using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using App1.Model;

namespace App1.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<Items> Item { get; set; }

        public MainViewModel() {
            this.Item = new ObservableCollection<Items>();
            Items i1 = new Items { Name = "1.jpg", Path = "/Assets/Images/1.jpg" };
            Items i2 = new Items { Name = "2.jpg", Path = "/Assets/Images/2.jpg" };
            Items i3 = new Items { Name = "3.jpg", Path = "/Assets/Images/3.jpg" };
            Items i4 = new Items { Name = "4.jpg", Path = "/Assets/Images/4.jpg" };
            Items i5 = new Items { Name = "5.jpg", Path = "/Assets/Images/5.jpg" };
            Items i6 = new Items { Name = "6.jpg", Path = "/Assets/Images/6.jpg" };

            Item.Add(i1);
            Item.Add(i2);
            Item.Add(i3);
            Item.Add(i4);
            Item.Add(i5);
            Item.Add(i6);

        }
    }
}
