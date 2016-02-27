using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder {
    class Program {
        static void Main(string[] args) {
            Scanner sc = new Scanner(Console.In);

        }

        #region テンプレ

        class Scanner {
            TextReader tr;
            String[] terms;
            int i;

            public int NextInt() {
                if (terms == null || i == terms.Count()) {
                    terms = tr.ReadLine().Split(' ');
                    i = 0;
                }

                int n;
                if (int.TryParse(terms[i], out n)) {
                    i++;
                    return n;
                } else {
                    i++;
                    return NextInt();
                }
            }

            public double NextDouble() {
                if (terms == null || i == terms.Count()) {
                    terms = tr.ReadLine().Split(' ');
                    i = 0;
                }

                double n;
                if (double.TryParse(terms[i], out n)) {
                    i++;
                    return n;
                } else {
                    i++;
                    return NextDouble();
                }
            }

            public String NextString() {
                if (terms == null || i == terms.Count()) {
                    terms = tr.ReadLine().Split(' ');
                    i = 0;
                }

                if (terms[i] == "") {
                    i++;
                    return NextString();
                } else {
                    return terms[i++];
                }
            }

            public Scanner(TextReader tr) {
                terms = null;
                this.tr = tr;
                i = 0;
            }
        }

        #endregion
    }
}
