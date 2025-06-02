using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDesign.Singleton {
	public class PrinterSingleton {
		private static PrinterSingleton instance;

		private PrinterSingleton() { }

		public static PrinterSingleton getInstance() {
			if (instance == null) instance = new PrinterSingleton();

			return instance;
		}

		public void printOneLine(string[] ss) {
			foreach (string s in ss) {
				Console.Write(s);
			}
		}

		public void printNewLine(string[] ss) {
			foreach (string s in ss) {
				Console.WriteLine(s);
			}
		}

		public void printSpacedLines(string[] ss) {
			foreach (string s in ss) {
				Console.WriteLine(s + "\n");
			}
		}
	}
}