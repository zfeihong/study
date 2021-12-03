using Jackyfei.Application;
using Jackyfei.Application.Constracts;

//常用做法
IPerson boy = new Boy("梁朝伟");
boy.SayHello();

IPerson girl = new Girl("俞飞鸿");
girl.SayHello();

//如何动态获取实现接口的所有实例
var types = AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IPerson))))
                        .ToList();

foreach (Type t in types)
{
    //var person = (IPerson)Activator.CreateInstance(t)!;
    var person = (IPerson)Activator.CreateInstance(t, new object[] { "中性人" })!;

    person.SayHello();
}

//如何判断实例对象的构造函数是否有参数
foreach (Type v in types)
{
    if (v.GetConstructors().Any(x => x.GetParameters().Any()))
    {
        Console.WriteLine($"{v.Name}=>有参构造函数");
    }
    else
    {
        Console.WriteLine($"{v.Name}=>无参构造函数");
    }
}

foreach (Type t in types)
{
    IPerson person;
    if (t.GetConstructors().Any(x => x.GetParameters().Any()))
    {
        //有参构造函数
        person = (IPerson)Activator.CreateInstance(t, new object[] { "德华" })!;
    }
    else
    {
        //无参构造函数
        person = (IPerson)Activator.CreateInstance(t, new object[] { })!;
    }
    person.SayHello();
}