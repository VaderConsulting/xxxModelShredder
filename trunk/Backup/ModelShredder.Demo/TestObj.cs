using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelShredder.Demo
{
    /// <summary>
    /// A simple demo Object.
    /// </summary>
    public class TestObj
    {
        public TestObj(int key, TestObj obj)
        {
            Key = key;
            Guid = Guid.NewGuid();

            Obj = obj;

            // We want deterministic behaviour.
            Random rand = new Random(key + 1846555464);

            DA = rand.Next();
            DB = rand.Next();
            DC = rand.Next();
            DD = rand.Next();

            SA = "ABCDEFGHIKKLMNOPQRSTUVWXYSZ";
            SB = SA + rand.Next().ToString();
            SC = rand.Next().ToString() + SB;
            SD = rand.Next().ToString() + SA;
        }

        public TestObj(int key)
            : this(key, null)
        {

        }

        public decimal Key;
        public Guid Guid;

        public decimal DA { get; set; }
        public decimal DB { get; set; }
        public decimal DC { get; set; }
        public decimal DD { get; set; }

        public string SA { get; set; }
        public string SB { get; set; }
        public string SC { get; set; }
        public string SD { get; set; }

        public TestObj Obj { get; private set; }
    }

}
