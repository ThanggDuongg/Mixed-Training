using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullBased
{
    public class RandomEventSource
    {
        private readonly Random _random = new Random();

        public IObservable<int> GetEvents()
        {
            return Observable.Create<int>(observer =>
            {
                Timer timer = null;
                timer = new Timer(state =>
                {
                    observer.OnNext(_random.Next());
                }, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

                return Disposable.Create(() =>
                {
                    timer.Dispose();
                });
            });
        }
    }
}
