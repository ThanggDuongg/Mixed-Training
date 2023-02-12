# IQueryable in .NET

IQueryable là một interface trong .NET Framework, cho phép truy vấn dữ liệu dạng lazy (trễ) và có thể chỉnh sửa các truy vấn trước khi thực thi. Ví dụ sau cho thấy cách sử dụng IQueryable trong .NET:

1) Tạo một context cở sở dữ liệu:

```cs
public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}
```

2) Tạo một lớp Product với các thuộc tính:

```cs
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}
```

1) Sử dụng IQueryable trong một method để truy vấn dữ liệu:

```cs
public List<Product> GetProducts(string category)
{
    using (var context = new ProductContext())
    {
        var products = context.Products.AsQueryable();

        if (!string.IsNullOrEmpty(category))
        {
            products = products.Where(p => p.Category == category);
        }

        return products.ToList();
    }
}
```

> Trong ví dụ trên, chúng ta sử dụng IQueryable để truy vấn dữ liệu từ bảng Products trong cơ sở dữ liệu. Nếu category có giá trị, chúng ta sử dụng phương thức Where để lọc các sản phẩm có Category bằng giá trị category. Sau đó, chúng ta gọi phương thức ToList để thực thi truy vấn và trả về kết quả.
>
> Khi bạn sử dụng `context.Products.Where(p => p.Category == category)`, bạn đang sử dụng một truy vấn dạng __*eager*__ (không trễ) để truy vấn dữ liệu. Khi bạn gọi phương thức Where, truy vấn sẽ được thực thi ngay lập tức và trả về kết quả.
>
> Trong khi đó, sử dụng IQueryable cho phép bạn chỉnh sửa các truy vấn trước khi thực thi, và chỉ khi bạn gọi phương thức ToList hoặc ToArray hoặc phương thức khác tương tự, truy vấn mới được thực thi.
>
> __Do đó, sử dụng IQueryable cho phép bạn tối ưu hóa các truy vấn dữ liệu và giảm tải cho cơ sở dữ liệu.__

## Detail

__IQueryable cho phép  chỉnh sửa các truy vấn trước khi thực thi__ nghĩa là IQueryable cung cấp một cách linh hoạt để *xử lý và chỉnh sửa các truy vấn dữ liệu trước khi __gửi đến cơ sở dữ liệu để thực thi__*. Điều này có nghĩa là có thể tạo ra một truy vấn, sau đó sử dụng các phương thức như `Where`, `OrderBy`, `Take` hoặc `Skip` để chỉnh sửa truy vấn, trước khi gọi `ToList` hoặc `FirstOrDefault` để thực thi truy vấn và lấy kết quả.

Vì việc chỉnh sửa truy vấn được thực hiện trước khi thực thi, nên IQueryable có thể giúp tối ưu hóa tốc độ xử lý truy vấn và giảm tải trên cơ sở dữ liệu.

## Example

```cs
students.Where(x => x.Id <= 3).OrderBy(x => x.Id);
students.AsQueryable().Where(x => x.Id <= 3).OrderBy(x => x.Id);
```

`students.Where(x => x.Id <= 3).OrderBy(x => x.Id)` và `students.AsQueryable().Where(x => x.Id <= 3).OrderBy(x => x.Id)` đều làm việc tương tự, tuy nhiên có một sự khác biệt chính.

`students.Where(x => x.Id <= 3).OrderBy(x => x.Id)` sẽ trả về một `IEnumerable<Student>`, trong khi `students.AsQueryable().Where(x => x.Id <= 3).OrderBy(x => x.Id)` sẽ trả về một `IQueryable<Student>`.

__Trong Entity Framework 6, các truy vấn dữ liệu sẽ được thực thi trên cơ sở dữ liệu nếu sử dụng IQueryable__, trong khi việc sử dụng IEnumerable sẽ thực hiện truy vấn trên máy tính của bạn.

Vì vậy, để tối ưu hóa tốc độ xử lý truy vấn và giảm tải trên cơ sở dữ liệu, Entity Framework 6 nên sử dụng IQueryable khi thực hiện truy vấn dữ liệu.

> Sử dụng database => IQueryable, không sử dụng database => IEnumarable

## Lazy & Eager in EF

### Lazy

Truy vấn Lazy IQueryable là một kiểu truy vấn dữ liệu trong Entity Framework (EF) được thực thi một cách "tự động". Điều này có nghĩa là truy vấn chỉ được thực thi khi dữ liệu được truy xuất thực sự, không phải khi truy vấn được tạo ra.

Ví dụ, nếu bạn có một truy vấn `IQueryable<Student> students = context.Students.Where(s => s.Age > 18)`, truy vấn này chỉ được thực thi khi bạn gọi `students.ToList()` hoặc truy xuất dữ liệu từ `students` theo bất kỳ cách nào khác.

Truy vấn Lazy IQueryable giúp tối ưu hóa tốc độ xử lý và giảm tải trên cơ sở dữ liệu bởi chỉ thực thi truy vấn khi cần thiết, tránh thực thi truy vấn không cần thiết. Tuy nhiên, truy vấn Lazy cũng có nhược điểm là có thể dẫn đến một số lỗi khi chưa chính xác xác định truy vấn và có thể gây khó khăn trong việc debug.

### Eager

Truy vấn Eager là một kiểu truy vấn dữ liệu trong Entity Framework (EF) được thực thi một cách "tức thì". Điều này có nghĩa là truy vấn được thực thi ngay khi nó được tạo ra.

Ví dụ, nếu bạn có một truy vấn `IEnumerable<Student> students = context.Students.Where(s => s.Age > 18).ToList()`, truy vấn này sẽ được thực thi ngay khi nó được tạo ra và dữ liệu sẽ được load vào bộ nhớ.

Truy vấn Eager có ưu điểm là dễ dàng debug và giúp tránh lỗi khi chưa chính xác xác định truy vấn. Tuy nhiên, truy vấn Eager cũng có nhược điểm là có thể dẫn đến tải quá nặng trên cơ sở dữ liệu và tốc độ xử lý chậm hơn.
