using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALS_PROJECT_OOP
{
    internal class Methods
    {
        public List <string[]> Accs = Read();
        public int index = INDEX();
        static int INDEX()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\Krizan246\\Downloads\\Index.txt"))
            {
                return int.Parse(sr.ReadLine());
            }
        }
        static List<string[]> Read()
        {
            List<string[]> Accs = new List<string[]>();
            using (StreamReader sr = new StreamReader("C:\\Users\\Krizan246\\Downloads\\Accounts.txt"))
            {
                string line;
                string[] s = new string[2];
                while ((line = sr.ReadLine()) != null)
                {
                    s = line.Split('.', System.StringSplitOptions.RemoveEmptyEntries);

                    Accs.Add(s);
                }
            }
            return Accs;
        }
        public void Write()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Krizan246\\Downloads\\Accounts.txt"))
            {
                for (int i = 0; i < Accs.Count; i++)
                {
                    sw.WriteLine($"{Accs[i][0]}.{Accs[i][1]}");
                }
            }
        }
    }
}
