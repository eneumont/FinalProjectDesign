using FinalProjectDesign.Bridge;
using FinalProjectDesign.Singleton;

public class Program {
	public static void Main(string[] args) {
		PrinterSingleton.getInstance().printSpacedLines([new Sheep(new makeAnimal(), "Shawn").make(), new Otter(new makeAnimal(), "Rosa").make()]);
	}
}