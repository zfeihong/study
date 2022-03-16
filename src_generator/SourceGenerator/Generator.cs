using Microsoft.CodeAnalysis;
using System.Text;

namespace SourceGenerator
{
    /// <summary>
    /// 1、应用两个包
    /// 2、Generator特性
    /// 3、实现ISourceGenerator接口、或者最新的IIncrementalGenerator
    /// 4、目标框架目前暂时只支持.NET Standard 2.0
    /// </summary>
    [Generator]
    public class Generator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
             
        }

        public void Execute(GeneratorExecutionContext context)
        {
            StringBuilder sb=new StringBuilder(@"
                using System;
                namespace HelloWorldGenerated
                {
                    public static class HelloWorld
                    {
                        public static void SayHello()
                        {
                            Console.WriteLine(""Hello World from Jackyfei"");
                        }
                    }
                }
            ");

            context.AddSource("helloWorldGenerated",sb.ToString());
        }

    }
}