# Pull-based

---
In a pull-based system, the consumer is in control of when it wants to receive the data. The consumer actively requests data from the provider, and the provider sends data only in response to these requests.

This approach is commonly used in the implementation of iterators in programming languages, where the consumer (e.g. a __`foreach`__ loop) asks for the next item in the sequence until all items have been processed.

An example of a pull-based system in C# is the __`IEnumerable<T>`__ interface, which allows you to iterate over a collection of items using a __`foreach`__ loop. The __`foreach`__ loop requests the next item in the sequence each time it loops, and the implementation of __`IEnumerable<T>`__ is responsible for providing the next item.

---

## Example

```cs
public class FibonacciSequence
{
    public IEnumerable<int> GetSequence()
    {
        int current = 0;
        int next = 1;
        while (true)
        {
            yield return current;
            int temp = next;
            next = current + next;
            current = temp;
        }
    }
}

...

FibonacciSequence sequence = new FibonacciSequence();
foreach (int number in sequence.GetSequence().Take(10))
{
    Console.WriteLine(number);
}
```

---

## Vietnamese

> __*Push-based*__ và __*Pull-based*__ là hai kỹ thuật khác nhau để truyền dữ liệu giữa các đối tượng trong lập trình hướng đối tượng.
>
> * __Push-based__ (Đẩy dữ liệu): Đối tượng nguồn tự nhận sự yêu cầu của đối tượng nhận và tự gửi dữ liệu cho đối tượng nhận. Ví dụ, trong C#, __`IEnumerable là một interface push-based, nó được sử dụng để truyền dữ liệu từ một đối tượng nguồn cho một đối tượng nhận, đối tượng nguồn sẽ tự động gửi các phần tử trong danh sách cho đối tượng nhận.
>
> Trong ví dụ về push-based __`IEnumerable`__ trên, đối tượng nguồn là __`FibonacciSequence`__ và đối tượng nhận là __`foreach`__ loop.
>
> __`FibonacciSequence`__ là một lớp tạo ra một chuỗi số Fibonacci và sử dụng __`yield`__ để push các phần tử của nó ra ngoài cho bất kỳ đối tượng nào muốn sử dụng nó.
>
> __`foreach`__ loop là một đối tượng nhận
