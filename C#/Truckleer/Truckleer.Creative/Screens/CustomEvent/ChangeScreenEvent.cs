using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Creative.Screens.CustomEvent
{
    public class ChangeScreenEvent<T>
    {
        public T CustomClass;

        //001_2: Multicast delegate type that 
        //get coupled with the event.
        public delegate void OnChangeScreen(
          object sender, EventArgs e);

        //001_3: Published event (StockLow), 
        //that takes responsibility of sending 
        //notification to the scbscriber through 
        //the above Specified multicast delegate
        public event OnChangeScreen ChangeScreen;

        //001_4: Constructor that Initializes 
        //the Stock
        public ChangeScreenEvent()
        {
           
        }

        //001_5: This function reduces the stock 
        //based on the sales on the billing 
        //counters. When the stock in hand is 
        //lower than 5, it raises the 
        //StockLow event.
        public void Change(T Object_)
        {
            CustomClass = Object_;
            EventArgs arg = new EventArgs();
            ChangeScreen(this, arg);
        }
    }
}
