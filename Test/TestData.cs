using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class TestData0
    {
        public string Guid0 { get; set; } = Guid.NewGuid().ToString();
        public string Guid1 { get; set; } = Guid.NewGuid().ToString();
        public string Guid2 { get; set; } = Guid.NewGuid().ToString();

        public static ObservableCollection<TestData0> Data { get; set; } =
            [
                new(),
                new(),
                new(),
                new(),
            ];
    }
}
