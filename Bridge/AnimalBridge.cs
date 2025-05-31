using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDesign.Bridge {
	public enum AnimalType {
		Sheep,
		Otter
	}

	public abstract class Animal {
		public Animal(AnimalMaker maker, string name) {
			Maker = maker;
			Name = name;
		}

		public string Name;
		public AnimalType Type;

		protected AnimalMaker Maker;

		public string make() {
			return Maker.make(Name, Type);
		}
	}

	public class Sheep : Animal {
		public Sheep(AnimalMaker maker, string name) : base(maker, name) {
			Type = AnimalType.Sheep;
		}
	}

	public class Otter : Animal {
		public Otter(AnimalMaker maker, string name) : base(maker, name) {
			Type = AnimalType.Otter;
		}
	}

	public interface AnimalMaker {
		abstract public string make(string name, AnimalType type);
	}

	class makeAnimal : AnimalMaker {
		public string make(string name, AnimalType type) {
			return name + " the " + type.ToString() + " is made...";
		}
	}
}
