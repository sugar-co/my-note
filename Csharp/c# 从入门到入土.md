## 1.输入输出

![image](https://note.youdao.com/yws/api/personal/file/2325EFA3565240DC9C89329CEE570D48?method=download&shareKey=793c48ec6be5aee19453155516ad1e1a)


## 2.数据类型

### 值类型


### 引用类型
#### Dynamic

  您可以存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生的。

#### String

字符串（String）类型的值可以通过两种形式进行分配：引号和 @引号。

C# string 字符串的前面可以加 @（称作"逐字字符串"）将转义字符（\）当作普通字符对待，比如：

```
string str = @"C:\Windows";
```
  大量使用+做字符串连接的效率很低，最好使用StringBuilder

  ```
  
  ```

  String 不支持 >,<等比较操作符，需要使用CompareTo方法

判断null和空，空白string

```c#
if(name == null)
if(string.isNullOrEmpty(name))
if(string.isNullOrWhiteSpace(name))
```

#### 格式化字符串

- 可以使用==操作符或者string的Equals方法来进行字符串的等值比较

```c#
NumberFormatInfo f = new NumberFormatInfo();
f.CurrencySymbol = "$$";
Console.WriteLine(3.ToString("c7", f));
```

##### 三种格式提供器

- NumberFormationInfo
- DateTimeFormatInfo
- CultureInfo



#### Array

  ```c#
  // 矩形数组
  int [,] matrix = new int [3,3];
  matrix.GetLength(0);
  matrix.GetLength(1);
  // 交错数组
  int [][] matric = new int[3][];
  matrix.Length;
  matrix[i].Length;
  ```

  

### 指针类型
声明指针类型的语法：
```
type* identifier;

char* cptr;
int* iptr;
```

## 3.类型转换

### is 运算符
is 运算符检查表达式结果的运行时类型是否与给定类型兼容。

```c#
int i = 23;
object iBoxed = i;
int? jNullable = 7;
if (iBoxed is int a && jNullable is int b)
{
    Console.WriteLine(a + b);  // output 30
}
```





### as 运算符

`as` 运算符将表达式结果显式转换为给定的引用或可以为 null 值的类型。 如果无法进行转换，则 `as` 运算符返回 `null`。 与强制转换表达式不同，<u>**`as`运算符永远不会引发异常。**</u>

```c#
IEnumerable<int> numbers = new[] { 10, 20, 30 };
IList<int> indexable = numbers as IList<int>;
if (indexable != null)
{
    Console.WriteLine(indexable[0] + indexable[indexable.Count - 1]);  // output: 40
}
```

### 强制转换表达式

```c#
double x = 1234.7;
int a = (int)x;
Console.WriteLine(a);   // output: 1234

IEnumerable<int> numbers = new int[] { 10, 20, 30 };
IList<int> list = (IList<int>)numbers;
Console.WriteLine(list.Count);  // output: 3
Console.WriteLine(list[1]);  // output: 20
```

### 转换


## 4.运算符

### 算术运算符
`+ - * / % ++ --`

### 逻辑运算符
`&& || !`

### 位运算符
`& | ^ ~ << >>`

### 赋值运算符
```
=  +=  -=  *=  /=  %= 
<<= >>=  &= ^= |=
```

### 其他运算符
```
$ 返回变量的地址。

* 变量的指针。

? :	条件表达式	如果条件为真 ? 则为 X : 否则为 Y

is	判断对象是否为某一类型。	If( Ford is Car) // 检查 Ford 是否是 Car 类的一个对象。

as	强制转换，即使转换失败也不会抛出异常。	
Object obj = new StringReader("Hello");
StringReader r = obj as StringReader;
```

## 5.参数传递

### 值参数

### 引用参数
```
public void swap(ref int x, ref int y)
```

### 输出参数
```
public void getValue(out int x)
```

### params修饰符 可变参数

```c#
static int Sum(params int[] ints)
{
    int sum = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        sum += ints[i];
    }
    return sum;
}
```



## 6.可空类型

### ? 

单问号用于对 int,double,bool 等无法直接赋值为 null 的数据类型进行 null 的赋值，意思是这个数据类型是 NullAble 类型的。
```
int? i = 3 
等同于
Nullable<int> i = new Nullable<int>(3);

int i; //默认值0
int? ii; //默认值null
```

### ??

如果第一个操作数的值为 null，则运算符返回第二个操作数的值，否则返回第一个操作数的值。

### ?.



### Nullable<T>的常用属性和方法
- HasValue //null:false;
- Value //底层值类型的值
- GetValueOrDefault() //底层值类型的值或该类型的默认值
- GetValueOrDefault(默认值)//底层值类型的值或指定的默认值

## 7.数组
```
double[] balance = new double[10]
double[] balance = {2345.0, 2234.0, 3421.0}
```

## 8.多态

### 静态多态
C# 提供了两种技术来实现静态多态性。分别为：
- 函数重载
- 运算符重载
```

```

### 动态多态
动态多态性是通过 **抽象类** 和 **虚方法** 实现的。

C# 允许您使用关键字 abstract 创建抽象类，用于提供接口的部分类的实现

虚方法是使用关键字 virtual 声明的。

## 9.接口

接口定义了属性、方法和事件，这些都是接口的成员。接口只包含了成员的声明。

接口使得实现接口的类或结构在形式上保持一致。

==接口声明默认是 public 的==


## 10.特性
.net框架提供了三种预定义特性：
- AttributeUsage
- Conditional
- Obsolete

[特性视频](https://www.bilibili.com/video/BV1At411N74o?p=8)

[视频2](https://www.bilibili.com/video/BV1fC4y1a7QU)


### AttributeUsage
预定义特性 AttributeUsage 描述了如何使用一个自定义特性类
```
[AttributeUsage(
   validon,
   AllowMultiple=allowmultiple,
   Inherited=inherited
)]
```
- AttributeTargets
  + AttributeTargets.Class
  + AttributeTargets.Property

#### 通过反射获取attribute

```c#
Student s = new Student() { Id = 22, Name = "yzj" };
Type type = s.GetType();
if (type.IsDefined(typeof(CustomAttribute), true))
{
    Type t = typeof(CustomAttribute);
    object o = type.GetCustomAttribute(t, true);
    MethodInfo methodInfo = t.GetMethod("Show");
    methodInfo?.Invoke(o, new object[] { });



    //CustomAttribute attribute = (CustomAttribute)type.GetCustomAttribute(typeof(CustomAttribute), true);
    //attribute.Show();
}
```

#### 通过反射完成类型转换

```c#
// Student.cs
class Student
{
    public int Id;
    public string Name { get; set; }
    public string Phone { get; set; }
}

// StudentDTO.cs
class StudentDTO
{
    public int Id;
    public string Name { get; set; }
    public string Phone { get; set; }
}

// Program.cs
static void Main(string[] args)
{
    Student student = new Student()
    {
        Id = 1,
        Name = "袁铭璋",
        Phone = "13698035271"
    };
    // 第一种
    StudentDTO studentDTO = new StudentDTO()
    {
        Id = student.Id,
        Name = student.Name,
        Phone = student.Phone
    };

    //第二种
    StudentDTO studentDTO1 = Trans<Student, StudentDTO>(student);

    //第三种
    string strStudent = JsonConvert.SerializeObject(student);
    StudentDTO studentDTO2 = JsonConvert.DeserializeObject<StudentDTO>(strStudent);
    
    // 第四种 automapper
    
    // 第五种 表达式目录树
}

static TOut Trans<TIn,TOut>(TIn tIn)
{
    Type typeOut = typeof(TOut);
    Type typeIn = typeof(TIn);
    TOut tOut = (TOut)Activator.CreateInstance(typeOut);
    foreach(var prop in typeOut.GetProperties())
    {
        PropertyInfo propInfo = typeIn.GetProperty(prop.Name);
        object oValue = propInfo.GetValue(tIn);
        prop.SetValue(tOut, oValue);
    }
    foreach (var field in typeOut.GetFields())
    {
        FieldInfo fieldInfo = typeIn.GetField(field.Name);
        object oValue = fieldInfo.GetValue(tIn);
        field.SetValue(tOut, oValue);
    }
    return tOut;
}
```



## 11.反射


```c#
//1.动态加载DLL
Assembly assembly = Assembly.Load("AspNetCore.DB.SqlServer");
Assembly assembly1 = Assembly.LoadFile(@"C:\Users\admin\source\repos\AspNetCore.Project\AspNetCore.Myflection\bin\Debug\netcoreapp3.1\AspNetCore.DB.SqlServer.dll");
Assembly assembly2 = Assembly.LoadFrom("AspNetCore.DB.SqlServer.dll");
foreach (var type1 in assembly1.GetTypes())
{
Console.WriteLine($"{type1.FullName}");
}

Console.WriteLine("==============获取类型================");
//2.获取类型
Type type = assembly.GetType("AspNetCore.DB.SqlServer.SqlServerHelper");
Console.WriteLine(type);
//3.创建对象
object oSqlserverHelper = Activator.CreateInstance(type);
//4.类型转换
//((SqlServerHelper)oSqlserverHelper).Query();
//IDBHelper dBHelper = (IDBHelper)oSqlserverHelper;
IDBHelper dBHelper = oSqlserverHelper as IDBHelper;
//5.调用方法
dBHelper.Query();
```

### 直接通过object 对象返回方法

```c#
object o = Activator.CreateInstance(type);
///访问public method
MethodInfo Query = type.GetMethod("Query", new Type[] { typeof(string) });
Query.Invoke(o, new object[] { "123" });
//访问private
MethodInfo Query = type.GetMethod("Query",BindingFlags.NonPublic | BindingFlags.Instance);
Query?.Invoke(o, new object[] { 2, "倾国倾城~~"});
```

### 调用泛型方法

```c#
Type typeMake = type.MakeGenericType(new Type[]{typeof(int),typeof(string)});
object oGeneric = Activator.CreateInstance(typeMake);
```



## 12.属性

### 访问器
访问器（accessor）声明可包含一个 get 访问器、一个 set 访问器，或者同时包含二者。





## 13.关键字

### sealed

 当对一个类应用 sealed 修饰符时，此修饰符会阻止其他类从该类继承。类似于Java中final关键字。

### when

```c#
catch (HttpRequestException e) when (e.Message.Contains("301"))
{
    return "Site Moved";
}
```



### nameof

`nameof` 运算符返回任何变量、类型或类型成员的名称。

## 14.修饰符

## 15.泛型

```c#

```

### 协变，逆变，不变

- Covariance 协变，当值作为返回值out输出
- Contravariance 逆变，当值作为输入input
- Invariance 不变？ 当值既是输入又是输出

```c#
public interface IEnumerable<out T>
public delegate void Action<in T>
public interface IList<T>
    
    

namespace DelegateMyFunc
{
    public delegate TResult MyFunc<in T1, in T2, out TResult>(T1 t1, T2 t2);
    class Program
    {
        static void Main(string[] args)
        {
            // 第一种
            {
                MyFunc<int, string, bool> myFunc = new MyFunc<int, string, bool>(test);
                Console.WriteLine(myFunc.Invoke(1, "ss"));
            }

            // 第二种 匿名方法
            {
                MyFunc<bool, int, string> myFunc = new MyFunc<bool, int, string>(delegate (bool arg1, int arg2) { return "wuwu"; });
            }

            // 第三种 Lambda表达式
            {
                MyFunc<int, string, bool> myFunc = (arg1, arg2) => true;
            }
        }

        public static bool test(int t1, string t2)
        {
            return true;
        }

    }
}

```

- variance 只能出现在接口和委托里。



## 16.委托

委托是类(IL)

- 委托是不可变的（like string）
- 使用+=或-=操作符是，实际上是创建了新的委托实例，并把它赋给当前的委托变量。
- 如果多播委托的返回类型不是void，那么调用者从最后一个被调用的方法来接收返回值。前面的方法仍然会被调用，但是其返回值就被弃用了。
- 所有的委托都是互不相容的，即使方法签名一样

```c#
delegate void D1();
delegate void D2();
D1 d1 = Method1;
D2 d2 = d1; //Compile-time error


```



### 属性

- Target 
- method

### 实例方法目标和静态方法目标

- Target 
- method

### Func和Action委托

使用泛型委托，就可以写出这样一组委托类型，他们可调用的方法可以拥有任意的返回类型和任意（合理）数量的参数。
- T Func<out T>(T t)
- void Action<in T>(T t)


### 委托的兼容性-参数
- 当你调用一个方法时，你提供的实参(argument)可以比形参(aprameter)定义更具体。（委托的参数可以比方法的参数更具体）
- 委托可以接受比它的方法目标更具体的参数类型。

## 17.事件

- 事件是一种结构，为了实现广播者、订阅者模型，它只暴露了所需的委托特性的部分子集。
- 事件的主要目的就是防止订阅者之间互相干扰。

```c#
public class PriceChangedEventArgs : EventArgs
{
    public readonly decimal OldPrice;
    public readonly decimal NewPrice;
    public PriceChangedEventArgs(decimal oldPrice, decimal newPrice)
    {
        OldPrice = oldPrice;
        NewPrice = newPrice;
    }
}

public class Stock
{
    string symbol;
    decimal price;
    public Stock(string symbol)
    {
        this.symbol = symbol;
    }

    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value == price) return;
            decimal oldPrice = price;
            price = value;
            OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
        }
    }
}

public class Program
{
    public static void Main()
    {
        Stock stock = new Stock("MSFT");
        stock.Price = 120;
        stock.PriceChanged += Stock_PriceChanged;
        stock.Price = 135;
    }

    static void Stock_PriceChanged(object sender,PriceChangedEventArgs e)
    {
        if((e.NewPrice - e.OldPrice) / e.OldPrice > 0.1M)
        {
            Console.WriteLine("Alert, 10% stock price increase!");
        }
    }
}
}
```

## 18.Lambda表达式

- Lambda表达式其实就是一个用来代替委托实例的未命名的方法；
- 编译器会把Lambda表达式转换为以下二者之一：

  + 一个委托实例
  + 一个表达式树(expression tree)

- Lambda表达式通常与Func和Action委托一起使用
- 





## 19.集合 Collection

- 集合的命名空间如下：

| 命名空间                      | 包括的类型             |
| ----------------------------- | ---------------------- |
| System.Collection             | 非泛型的集合类和接口   |
| System.Collection.Specialized | 强类型非泛型的集合类   |
| System.Collection.Generic     | 泛型集合类和接口       |
| System.Collection.ObjectModel | 自定义集合的代理和基类 |
| System.Collection.Consurrent  | 线程安全的集合         |

### 枚举

#### IEnumerable 和 IEnumerator

```c#
public interface IEnumerable<[NullableAttribute(2)] out T> : IEnumerable
{
    IEnumerator<T> GetEnumerator();
}


public interface IEnumerator
{
    object? Current { get; }
    bool MoveNext();
    void Reset();
}
```

### ICollection 和IList 接口

#### ICollection<T> 

- 属性
  + Count
  + IsReadOnly
- 方法
  + Contains
  + CopyTo
  + Add
  + Remove
  + Clear

#### ICollection

- 属性
  + Count
  + IsSynchronized
  + SyncRoot
- 方法
  + CopyTo

#### IList<T>

- 属性
  + this[int index] 索引器
- 方法
  + IndexOf
  + Insert
  + RemoveAt

#### IList

- 属性
  + this[int index] 索引器
  + IsFixedSize
  + IsReadOnly
- 方法
  + IndexOf
  + Insert
  + Remove
  + RemoveAt
  + Add
  + Clear
  + Contains

### Array

- Array提供了如下的方法和属性来查询长度和维数：

```c#
public int GetLength(int dimension);
public long GetLongLength(int dimension);

public int Length{get;}
public long LongLength{get;}

public int GetLowerBound(int dimension);
public int GetUpperBound(int dimension);
public int Rank{get;}
```

- Array 类提供了许多搜索一维数组元素的方法：
  + BinarySearch方法：快速在==排序数组==中找到特定元素
  + IndexOf/LastIndexOf方法：搜索未排序数组中的特定元素
  + Find/FindLast/FindIndex/FindAll/Exists/TrueForAll：搜索未排序数组中满足指定Predicate<T>的一个或多个元素。
- 

### List<T> 链表（列表）

### LinkedList<T> 双向链表

### Queue<T> 队列

### Stack<T> 栈

### HashSet<T> SortedSet<T>

### Dictionary<K,V> 字典

[C# 7.0](https://weread.qq.com/web/reader/710327c0718f6368710b285kd1f32d7024fd1fe173d0651)



## 20.扩展方法

扩展方法是一种静态方法，但可以像扩展类型上的实例方法一样进行调用。

```c#
static class test
{
    public static string Yzj(this string s)
    {
        string v = "this is a extend method";
        return s + v;
    }
}
```

扩展方法被定义为静态方法，但它们是通过实例方法语法进行调用的。

## 21.迭代器

使用 `yield return` 上下文关键字定义迭代器方法。

`yield break`语句表示迭代器块会提前退出，不再返回更多的元素。



## 22.异常

### System.Exception的关键属性

- StackTrace 
  + 它是一个字符串，展现了从异常发生地到catch块所有的被调用的方法。
- Message
  + 关于错误的描述信息
- InnerException
  + 引起外层异常的内层异常。而且InnerException本身还有可能含有InnerException

### 常见异常类型

- System.ArgumentException
- System.ArgumentNullException
- System.ArgumentOutOfRangeException
- System.InvalidOpeartionException
- System.NotSupportedException
- System.NotImpleMentedException
- System.ObjectDisposedException
- NullReferenceException

## 23.匿名类型

- 匿名类型就是由编译器即时创建的一个class，它用来存储一组数据
- 创建匿名类型：new + object 初始化器，并指定属性及其值
- 使用var关键字来引用匿名类，因为匿名类型没有名字
- 。。。

```c#
var dude = new {Name = "Bob", Age = 23};
```

[视频](https://www.bilibili.com/video/BV1At411N74o?p=6)

## 24.Tuple 元组

```c#
var bob = ("Box", 23);
Console.WriteLine(bob.Item1); // Box
Console.WriteLine(bob.Item2); //23
```

- Tuple是值类型，其元素是可变的(和python不同)

## 25.LINQ

- Where
- OrderBy
- Select
- Take
- Skip
- Reverse
- Rirst
- Split
- Last
- First
- ElementAt
- Concat
- Union
- Count
- ToArray
- ToList
- 

### 流式语法

```c#
IEnumerable<string> query = names
    .Where(n => n.Contains("a"))
    .OrderBy(n => n.length)
    .Select(n => n.ToUpper());
```

### 查询表达式

查询表达式一般以from子句开始，最后以select或者group子句借书。

```c#
IEnumerable<string> query = 
    from	n in names		
    where 	n.Contains("a")	//Filter elements
    orderby	n.Length		//Sort elements
    select	n.ToUpper();	//Translate each element (project)
```

### 延迟执行

## 26.依赖注入

### 构造函数注入

> 知道啦

### FromServices的操作注入

FromServicesAttribute 允许将服务直接注入到操作方法，而无需使用构造函数注入：

```c#
public IActionResult About([FromServices] IDateTime dateTime)
{
    return Content( $"Current server time: {dateTime.Now}");
}
```

### 从控制器访问设置

[微软文档](https://docs.microsoft.com/zh-cn/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-3.1#access-settings-from-a-controller)

## 27.过滤器

## 28.异步编程

### 线程

#### 什么是线程

- 线程是一个可执行路径，它可以独立与其它线程执行
- 每个线程都在操作系统的进程(Process)内执行，而操作系统进程提供程序运行的独立环境。
- 单线程应用，在进程的独立环境里只跑一个线程，所以该线程拥有独占权。
- 多线程应用，单个进程中会跑多个线程，它们会共享当前的执行环境(尤其是内存)

#### 线程的一些方法

- t.Start(); //开始线程
- t.Join(); //等待线程结束
- Thread.Sleep(4000);

调用Join时可以指定一个超时时间（以毫秒为单位或者用TimeSpan定义）。如果线程在指定时间内正常结束，则返回true；如果超时则返回false。

Thread.Sleep方法将当前线程的执行暂停指定的时间：

#### 阻塞

- 可以通过ThreadState这个属性来判断线程是否处于被阻塞的状态：

`bool blocked = (someThread.ThreadState & ThreadState.WaitSleepJoin) != 0;`

#### ThreadState

- Unstarted
- Running
- WaitSleepJoin
- Stopped

#### 锁

```c#
lock (_locker)
{
    if (!_done)
    {
        Console.WriteLine("done");
        Thread.Sleep(2000);
        _done = true;
    }
}
```

#### 异常处理

- 创建线程时在作用范围内的try/catch/finally块，在线程开始执行后就与线程无关了。

#### 前台和后台线程

- 可以通过IsBackground判断是否是后台线程。

#### 线程优先级

- 线程的优先级(Thread 的 Priority属性)决定了相当的于操作系统中其它活跃线程所占的执行时间。
- 优先级分为：
  + enum ThreadPriority{Lowest,BelowNormal,Normal,AboveNormal,Highest}

#### 提升线程优先级

- 提升线程优先级的时候需要特别注意，因为它可能”饿死“其它线程。

- 如果想让某线程(Thread)的优先级比其它进程(process)中的线程(Thread)高，那就必须提升进程(Process)的优先级

  + 使用System.Diagnostics下的Process类。

  ```c#
  using (Process p = Process.GetCurrentProcess())
      p.PriorityClass = ProcessPriorityClass.High;
  ```

  

#### 信号 Signaling

### Task 任务

与线程相比，Task是一个更高级的抽象概念，它代表了一个并发操作，而该操作并不一定依赖线程来完成。

- Task默认使用线程池，也就是后台线程

```c#
Task task = Task.Run(() =>
                     {
                         Thread.Sleep(3000);
                         Console.WriteLine("yzj");
                     });

Console.WriteLine(task.IsCompleted);

task.Wait();
```

#### Wait

- 调用task的wait方法会进行阻塞直到操作完成
  + 相当于调用thread上的Join方法
- wait也可以让你指定一个超时时间和一个取消令牌来提前结束等待。

#### Task的返回值

- Task 有一个泛型子类叫做Task<TResult>,它允许发出一个返回值。
- 使用Func<TResult>委托或兼容的Lambda表达式来调用Task.Run就可以得到Task<TResult>
- 随后，可以通过Result属性来获取返回的结果。
  + 如果这个rask还没有完成操作，访问Result属性会阻塞该线程直到改task完成操作。
- Task<TResult>可以看作是一种所谓的(future、promise),在它里面包裹着一个Result,在稍后的时候就会变得可用。

#### 延续 awaiter

```c#
Task<int> primeNumberTask = Task.Run(() =>
Enumerable.Range(2, 3000000).Count(n =>
Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));

var awaiter = primeNumberTask.GetAwaiter();
awaiter.OnCompleted(() =>
{
    int result = awaiter.GetResult();
    Console.WriteLine(result);
});
```

### 多线程

Thread: 类，一个封装，是.NetFramework对线程对象的抽象封装

通过Thread去完成的操作，最终是通过向操作系统请求得到的执行流

CurrentThread: 当前线程

ManagedThreadId: 是.Net平台给Thread起的名字，int值，尽量不重复