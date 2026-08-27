using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModelShredder.Demo
{
    public static class TestObjects
    {
        private static readonly int m_NumberOfTestObjs = 100000;

        public static readonly IList<TestObj> List;

        static TestObjects()
        {
            // Generate root list
            List = new List<TestObj>();
            for (int i = 0; i < m_NumberOfTestObjs; i++)
            {
                List.Add(new TestObj(i));
            }

        }
    }
}
