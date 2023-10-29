using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BenchmarkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<TestFilter>();
            Console.ReadKey();
        }
    }

    [HtmlExporter]
    [AsciiDocExporter]
    [CsvExporter]
    [CsvMeasurementsExporter]
    [PlainExporter]
    [RPlotExporter]
    [MemoryDiagnoser]
    public class TestFilter()
    {
        [Benchmark]
        public void ArrayFiler()
        {
            var values = new[] { "John", "OvO", "Eric", "Conte" };
            values.Where(x => x == "Eric");
        }

        [Benchmark]
        public void ListFiler()
        {
            var values = new List<string>() { "John", "OvO", "Eric", "Conte" };
            values.Where(x => x == "Eric");
        }

        [Benchmark]
        public void IEnumerableFiler()
        {
            var values = new[] { "John", "OvO", "Eric", "Conte" }.AsEnumerable();
            values.Where(x => x == "Eric");
        }
    }


}
