using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Exo.Views.Tools
{
    internal interface IObservable
    {
        List<IObserver> Observers { get; set; }

        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
