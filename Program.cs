using FinalProjectDesign.Bridge;
using FinalProjectDesign.Singleton;
using FinalProjectDesign.Visitor;

public class Program {
	public static void Main(string[] args) {
		new NameAndDescription().speak(new Farmer("Mike", [new Sheep(new makeAnimal(), "Aba"), new Sheep(new makeAnimal(), "Ben"), new Sheep(new makeAnimal(), "Coco"), new Otter(new makeAnimal(), "Ipapu")]));
		new NameAndDescription().speak(new Collector("Sam", [AnimalType.Sheep, AnimalType.Otter]));
	}
}