using Examples.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Tests.Classes
{
	[TestClass]
	public class AnimalTests
	{
		[TestMethod]
		void Main()
		{
			var listOfAnmial = new List<IAnimal>();

			Cat frisky = new Cat();
			frisky.Name = "Frisky";
			Console.WriteLine(frisky.Lives);
			listOfAnmial.Add(frisky);

			Dog charlie = new Dog();
			charlie.Name = "charlie";
			listOfAnmial.Add(charlie);

			Salmon nemo = new Salmon();
			nemo.Name = "nemo";
			listOfAnmial.Add(nemo);

			//Console.WriteLine(listOfAnmial;

			Play(frisky);
			Play(charlie);
			Play(nemo);


			//var animal = new Animal();
			//Play(animal);
		}

		public void Play(IAnimal animal)
		{
			//play with the animal
			Console.WriteLine(String.Format("playing with {0} and it said {1}", animal.Name, animal.Speak()));
		}
	}
}
