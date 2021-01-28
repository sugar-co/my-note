## DotNetCore
### 什么是.NETcore

.net core是.net的未来 

开发跨平台的.net应用

### 特性
- 跨平台
- 跨架构(x86\x64\ARM)
- 支持命令行
- 部署灵活、兼容性强
- 开源

==云原生和微服务==，是.NET Core比较核心的东西


### asp.netcore

- 启动流程
- 主机配置
- 依赖注入
- 服务
- 管道
- 中间件
- 应用配置
- 多环境
- 日志
- 路由
- 异常处理
- 静态文件
- 部署
- 


#### 主机
主机负责web应用程序的启动和生存期管理，配置服务器和请求处理管道

主机配置日志、依赖关系的注入

主机实际上是一个封装了应用资源的对象

创建主机生成器->配置主机->创建主机->运行主机

##### 配置
![image](https://note.youdao.com/yws/api/personal/file/DC8287F6727646BEA881B863F9B0FD8A?method=download&shareKey=793c48ec6be5aee19453155516ad1e1a)

### asp.netcore使用


## ASP .NET CORE MVC
### Controller  控制器

#### 定义控制器
1. TestController
2. [Controller]


#### 默认路由规则
- 域名/controller/action
- localhost:5000/test/hello


#### 控制器接受数据
```
-- HttpRequest对象
- QuerySTring   Request.Query["id"]
- Form          Request.Form[""]
- Cookie        Request.Cookie[""]
- Header
-- HttpContext对象
- Session       HttpContest.Session 
  + Session.Set
    - Session.SetString
    - Session.SetInt
    - Session.GetString
    - Session.GetInt32
  + Session.Remove
  + Session.TryGetValue
```

#### 数据绑定
- 把用户请求的数据绑定到控制器方法的参数上
- 支持简单类型和自定义类
- 绑定规则是请求数据名称与参数名称一致
  + 如查询字符串key名称与参数一致
  + Form表单名称与参数一致
  + 查询字符串或表单key的名称与类属性名称一致

Form > Route > Query
#### 相关特性

```
- [Controller]      控制器
- [NonController]   非控制器

- 特性              数据源
- [FromHeader]      Headers
- [FromRoute]       路由数据
- [FromBody]        请求体
- [FromForm]        表单数据
- [FromQuery]       查询字符串
- [FromServices]    服务注册

public IActionResult PostSay([FromQuery] string id)
```

#### IActionResult
- 动作结果接口
- 具体实现
  + JsonResult
  + RedirectResult
  + FileResult
  + ViewResult
  + ContentResult

```
实例化对象      封装方法
JsonResult      Json()
RedirectResult  Redirect()
FileResult      File()
ViewResult      View()
ContentResult   Content()
```


### View 视图

```
- 相对路径没有.cshtml
return View("Test");
return View("../../MyViews/Test");
return View("MyViews/Test.cshtml");
return View("~/MyViews/Test.cshtml");
```

- 母版页
- 部分视图

#### 母版页
##### 目标与作用
- 实现多个视图内容共享，减少编码量
- 便于系统维护

##### 母版页使用
- 跟普通视图创建一样
- @RenderBody()输出子页面内容
- 在子页面中==使用Layout指定母版页==
- @RenderSection

```
@section Scripts{
    <script src="~/js/CustomScript.js"></script>
}



<body>
    <div>
        @RenderBody()
    </div>

    @RenderSection("Scripts");
</body>
```


#### 部分视图
- 可以实现视图内容共享
- 可以在视图上通过@Html.Partial引入
- 可以作为视图结果返回return PartialView()

#### ViewStart使用
- 支持分层

#### ViewImports使用
- ViewImports用于包含公共命名空间
- 使用@using
- 支持分层

### 数据传递
- ViewData
- ViewBag
- Model
- TempData
- Cache
- Session

#### Model
```
UserModel model = new UserModel(){
    UserName = "test",
    Password = "123"
}
return View(model)

====================
@Model.UserName
@Model.Password

===================
强类型视图
@model lesson.Model.UserModel
```

#### TempData
- 视图级别
- 只允许消费一次
- 可多次赋值
- 键值对形式

> ViewData不能跨视图，TempData可以

#### Cache
- 应用程序级别
- 服务器端保存
- 可设置有效期
- 键值对形式
- 与.net framework时代不同，一种全新实现
- IMemoryCache接口
- 依赖注入方式获取
- IMemoryCache.Get
- IMemoryCache.Set





#### Session
- 会话级别
- 服务器端保存
- 键值对形式
- 通过HttpContext.Session获取Session对象
- Session.Set方法添加数据

```
ISession session = HttpContext.Session;
session.SetString("realname", "袁");
session.SetInt32("age", 22);

int? age = session.GetInt32("age");
string realname = session.GetString("realname");
```


### 数据验证

#### 特性
```
- [Required]
- [RegularExpression]
- [Compare]
- [Range]
- [Max]
- [Min]
- [StringLength]
- [DataType]



if(ModelState.IsValid){
    
}
```

## 路由

[路由约束](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/routing?view=aspnetcore-3.1#route-constraint-reference)

#### 路由模板
[路由模板](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/routing?view=aspnetcore-3.1#route-template-reference)

路由模板 `"{controller=Home}/{action=Index}/{id?}"` ：

- 匹配 URL 路径，例如`/Products/Details/5`
- `{ controller = Products, action = Details, id = 5 }`通过词汇切分路径来提取路由值。 如果应用有一个名为的控制器 `ProductsController` 和一个操作，则提取路由值将导致匹配 `Details` ：
- `/Products/Details/5`模型将的值绑定 `id = 5` ，以将 `id` 参数设置为 `5` 。 有关更多详细信息，请参阅[模型绑定](https://docs.microsoft.com/zh-cn/aspnet/core/mvc/models/model-binding?view=aspnetcore-3.1)。
- `{controller=Home}``Home`将定义为默认值 `controller` 。
- `{action=Index}``Index`将定义为默认值 `action` 。
- `?`中的字符 `{id?}` 定义 `id` 为可选。
- 默认路由参数和可选路由参数不必包含在 URL 路径中进行匹配。 有关路由模板语法的详细说明，请参阅[路由模板参考](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/routing?view=aspnetcore-3.1#route-template-reference)。
- 匹配 URL 路径 `/` 。
- 生成路由值 `{ controller = Home, action = Index }` 。

[文档](https://docs.microsoft.com/zh-cn/aspnet/core/mvc/controllers/routing?view=aspnetcore-3.1#conventional-routing)

- 

```
:alpha  /hello/{name:alpha}
:int    {id:int}
```

```c#
// Location 1: before routing runs, endpoint is always null here
app.Use(next => context =>
{
    Console.WriteLine($"1. Endpoint: {context.GetEndpoint()?.DisplayName ?? "(null)"}");
    return next(context);
});

app.UseRouting();

// Location 2: after routing runs, endpoint will be non-null if routing found a match
app.Use(next => context =>
{
    Console.WriteLine($"2. Endpoint: {context.GetEndpoint()?.DisplayName ?? "(null)"}");
    return next(context);
});

app.UseEndpoints(endpoints =>
{
    // Location 3: runs when this endpoint matches
    endpoints.MapGet("/", context =>
    {
        Console.WriteLine(
            $"3. Endpoint: {context.GetEndpoint()?.DisplayName ?? "(null)"}");
        return Task.CompletedTask;
    }).WithDisplayName("Hello");
});

// Location 4: runs after UseEndpoints - will only run if there was no match
app.Use(next => context =>
{
    Console.WriteLine($"4. Endpoint: {context.GetEndpoint()?.DisplayName ?? "(null)"}");
    return next(context);
});
```



- 调用 `UseRouting` 之前，终结点始终为 null。
- 如果找到匹配项，则 `UseRouting` 和 [UseEndpoints](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.aspnetcore.builder.endpointroutingapplicationbuilderextensions.useendpoints) 之间的终结点为非 null。
- 如果找到匹配项，则 `UseEndpoints` 中间件即为终端。 稍后会在本文档中定义[终端中间件](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/routing?view=aspnetcore-3.1#tm)。
- 仅当找不到匹配项时才执行 `UseEndpoints` 后的中间件。

#### 属性路由

```
[Route("[controller]/[action]")]
```

## 中间件
使用 RunMap 和 Use 扩展方法来配置请求委托。 可将一个单独的请求委托并行指定为匿名方法（称为并行中间件），或在可重用的类中对其进行定义。 这些可重用的类和并行匿名方法即为中间件，也叫中间件组件

[微软文档](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/middleware/?view=aspnetcore-3.1)

#### ASP .NET Core的中间件
- 可同时被访问和请求
- 可以处理请求后，然后将请求传递给下一个中间件
- 可以处理请求后，并使管道短路
- 可以处理传出响应
- 中间件是按照添加的顺序执行的

[MapWhen](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.aspnetcore.builder.mapwhenextensions.mapwhen) 基于给定谓词的结果创建请求管道分支。 `Func<HttpContext, bool>` 类型的任何谓词均可用于将请求映射到管道的新分支。 在以下示例中，谓词用于检测查询字符串变量 `branch` 是否存在：

[UseWhen](https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.aspnetcore.builder.usewhenextensions.usewhen) 也基于给定谓词的结果创建请求管道分支。 与 `MapWhen` 不同的是，如果这个分支不发生短路或包含终端中间件，则会重新加入主管道：


```
//添加默认文件
app.UseDefaultFiles();
//添加静态文件
app.UseStaticFiles();

app.Use();
app.Run();

app.Map("/map1", HandleMapTest1);

app.MapWhen(context => context.Request.Query.ContainsKey("branch"),
HandleBranch);

app.UseWhen(context => context.Request.Query.ContainsKey("branch"),
HandleBranchAndRejoin);
```

#### 中间件自定义

```c#
// TestMiddleware.cs
public class TestMiddleware
{
    private readonly RequestDelegate _next;

    public TestMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        // 中间件的业务代码！！！


        // 请求处理
        await _next(httpContext);
        // 响应处理
    }
}

// Startup.cs
// 调用中间件
app.UseMiddleware<TestMiddleware>();
```

#### 中间件扩展

```c#
public static class TestMiddlewareExtension
{
    /// <summary>
    /// 自定义中间件扩展
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static IApplicationBuilder UseTest(this IApplicationBuilder app)
    {
        app.UseMiddleware<TestMiddleware>();
        return app;
    }
}
```

#### 管道





## 环境变量


## 依赖注入
- AddSingleton()
- AddScoped()
- AddTransient()

#### AddSingleton()
顾名思义，AddSingleton()方法创建一个'Singleton'服务。首次请求是会创建'Singleton'服务。然后，所有后续的请求中都会使用相同的实例。因此，通常，每个应用程序只创建一次'Singleton'服务，并且在整个应用程序生命周期中使用该==单个实例==


#### AddScope()


- 依赖注入的亮点
  + 低耦合
  + 提高了高测试性，使单元测试更加容易

```
services.AddSingleton<IStudentRepository, MockStudentRepository>();
```


## Taghelper

```
<a asp-controller="home" asp-action="details" asp-route-id="@student.Id">查看</a>

<img src="~/images/image.jpg"  asp-append-version="true"/>
```

include和exclude属性
```
<environment include="Staging,Production">
    <link rel="stylesheet"
    href="">
</environment>
```

## Entity Framework Core, ORM
Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Relational

Microsoft.EntityFrameworkCore



## Dapper
[dapper文档](https://www.w3cschool.cn/dapperorm/dapperorm-toj931f2.html)

#### 安装
```
Install-Package Dapper
```
#### 连接
```
"ConnectionString": "Server=.;Database=test;User Id=sa;Password=123456"
```


#### 工作步骤
- 创建一个IDbConnection接口对象；
- 编写一个查询SQL来执行CRUD操作；
- 将查询SQL作为Execute方法的参数传递。



#### 方法
- Execute
- Query
- QueryFirst
- QueryFirstOrDefault
- QuerySingle
- QuerySingleOrDefault
- QueryMultiple
- ...

## 应用配置

```c#
var appSetting = new AppSetting();
_configuration.Bind(appSetting);

var webSetting = new WebSetting();
_configuration.GetSection("WebSetting").Bind(webSetting);

// 注册配置选项的服务
services.Configure<AppSetting>(_configuration);

func(IOptions<AppSettig> appOptions)
```



```c#
public class Factory{
    private static string IDBHelperConfig = ConfigurationManager.AppSettings["IDBHelperConfig"];
}
```

## 日志

+ 日志级别 LogLevel

builder.SetMinimumLevel(LogLevel.trace)

trace<debug<information<error<critical