using PullBased;

RandomEventSource source = new RandomEventSource();
IDisposable subscription = source.GetEvents().Subscribe(eventValue =>
{
    Console.WriteLine(eventValue);
});

Thread.Sleep(10000);

subscription.Dispose();