# 创建单元测试

单元测试框架现在使用的是 mstest. 

1. 使用 `dotnet new mstest -o 目录名` 来创建单元测试工程.

1. 引用需要测试的工程: 

    `dotnet add reference path-to-project.csproj`

1. 为了完整性, 在上层的 sln 中也把单元测试工程添加进去:

    `dotnet sln add path-to-project.csproj`

1. 如下是一些可用的单元测试注解, 要使用它们, 首先引用 `using Microsoft.VisualStudio.TestTools.UnitTesting` 这个包:

    - `[AssemblyInitialize]`: 二进制文件加载时候调用(注意方法签名)

    - `[AssemblyCleanup]`: 二进制文件卸载时候调用(注意方法签名)

    - `[ClassInitialize]`: 类初始化的时候调用(注意方法签名)

    - `[ClassCleanup]`: 类释放时候调用(注意方法签名)

    - `[TestInitialize]`: 每个测试方法调用前执行

    - `[TestCleanup]`: 每个测试方法调用后执行

    - `[TestClass]`: 标记单元测试类

    - `[TestMethod]`: 标记单元测试方法

1. 将单元测试添加到解决方案后, 直接在解决方案目录下执行 `dotnet test` 就能执行单元测试.

1. 关于 MSTest 里面可以使用的注解, 详见[官方文档](https://docs.microsoft.com/en-us/visualstudio/test/using-microsoft-visualstudio-testtools-unittesting-members-in-unit-tests?view=vs-2019).

有可能添加完了之后某些功能不工作, 需要重启一下 VS Code.

完整的内容可以查看[官方文档](https://docs.microsoft.com/zh-cn/dotnet/core/testing/unit-testing-with-mstest).