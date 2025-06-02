using FinalProjectDesign.Bridge;
using FinalProjectDesign.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDesign.Visitor {
	public interface IPeopleVisitor {
		void speak(Farmer farmer);
		void speak(Collector collector);
	}

	public class NameAndDescription : IPeopleVisitor {
		public void speak(Farmer farmer) {
			PrinterSingleton.getInstance().printNewLine(["Hi I'm " + farmer.Name + " the farmer.", "In my farm I have, "]);

			foreach (Animal a in farmer.Animals) {
				PrinterSingleton.getInstance().printNewLine([a.Name + " the " + a.Type.ToString().ToLower() + "."]);
			}
		}

		public void speak(Collector collector) {
			PrinterSingleton.getInstance().printNewLine(["Nice to meet you. I'm " + collector.Name + " the collector.", "My collection has, "]);

			foreach (AnimalType t in collector.Types) {
				PrinterSingleton.getInstance().printOneLine([t.ToString() + " "]);
			}
		}
	}

	public interface IPerson {
		void Accept(IPeopleVisitor visitor);
	}

	public class Farmer : IPerson {
		public string Name;
		public Animal[] Animals;

		public Farmer(string name, Animal[] animals) {
			Name = name;
			Animals = animals;
		}

		public void Accept(IPeopleVisitor visitor) {
			visitor.speak(this);
		}
	}

	public class Collector : IPerson {
		public string Name;
		public AnimalType[] Types;

		public Collector(string name, AnimalType[] types) {
			Name = name;
			Types = types;
		}

		public void Accept(IPeopleVisitor visitor) {
			visitor.speak(this);
		}
	}
}