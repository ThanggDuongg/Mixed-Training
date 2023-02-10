# Push-based

In a push-based system, the provider is in control of when it wants to send data to the consumer. The provider actively pushes data to the consumer, without the consumer having to request it. This approach is commonly used in event-driven systems, where the provider is responsible for sending notifications to the consumer whenever a certain event occurs.

An example of a push-based system in C# is the __`IObservable<T>`__ interface, which allows you to observe a sequence of items as they are produced. The implementation of __`IObservable<T>`__ is responsible for pushing notifications to the consumer (an __`IObserver<T>`__ instance) whenever a new item is produced.

---

## Example

```cs
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

...

RandomEventSource source = new RandomEventSource();
IDisposable subscription = source.GetEvents().Subscribe(eventValue =>
{
    Console.WriteLine(eventValue);
});

Thread.Sleep(10000);

subscription.Dispose();
```

---

## Vietnamese

> * __*Pull-based*__ (Kéo dữ liệu): Đối tượng nhận yêu cầu dữ liệu từ đối tượng nguồn. Ví dụ, trong C#, IObservable là một interface pull-based, nó cho phép đối tượng nhận đăng ký một sự kiện để nhận dữ liệu từ đối tượng nguồn, khi có dữ liệu mới, đối tượng nguồn sẽ gửi cho đối tượng nhận.
>
> * Tùy vào nhu cầu và mục đích của bạn, bạn có thể chọn giữa hai kỹ thuật này hoặc sử dụng cả hai để tạo ra một giải pháp lập trình tốt nhất cho bạn.
>
> Trong ví dụ về pull-based IObservable có thể là một đối tượng đại diện cho một số sự kiện ngẫu nhiên
>
> Với đoạn code trên, chúng ta sẽ tạo ra một đối tượng __`RandomEventSource`__ và sử dụng nó để tạo ra một stream các sự kiện ngẫu nhiên. Chúng ta cũng sử dụng __`Subscribe`__ để đăng ký một hành động để thực hiện với các sự kiện, trong trường hợp này là in ra màn hình.
>
> __`RandomEventSource`__ là đối tượng nguồn và __`Subscribe`__ là đối tượng nhận. __`RandomEventSource`__ tạo ra một stream các sự kiện ngẫu nhiên và sử dụng __`Observable.Create`__ để tạo một IObservable
>
> __`Đối tượng nguồn là IObservable, còn đối tượng nhận là IObserver`__.
