using System;

namespace SplitMethod {
    class Program {
        static void Main (string[] args) {
                string names = "joseph,ngugi,muiruri";
                string[] Jnames = names.Split (',');
                for(int i = 0; i<Jnames.Length; i++){
                    Console.WriteLine(Jnames[i]);
                }
        }
    }
}