using FinalProjectDesign.Singleton;

public class Program {
	public static void Main(string[] args) {
		PrinterSingleton.getInstance().printNewLine(["Testing... ", "Testing...", "1...", "2...", "3..."]);
	}
}