﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Models
{
	public interface IAnimal
	{
		String Name { get; set; }
		Int32 Weight { get; set; }
		String Color { get; set; }

		void Eat(string food);
		String Speak();
		void Move(String location);
	}

	public abstract class Animal : IAnimal
	{
		public String Name { get; set; }
		public Int32 Weight { get; set; }
		public String Color { get; set; }

		public void Eat(string food)
		{
			//eat
		}
		public virtual void Move(string location)
		{
			//move
		}
		public abstract String Speak();
	}

	public abstract class Mammal : Animal
	{

	}

	public abstract class Fish : Animal
	{
		public override String Speak()
		{
			return null;
		}

		public override void Move(string location)
		{
			//swim
		}
	}

	public abstract class Brid : Animal
	{

	}

	public class Cat : Mammal
	{
		public Int32 Lives = 9;

		public override String Speak()
		{
			return "Meow";
		}
	}



	public class Dog : Mammal
	{
		public override String Speak()
		{
			return "Woof";
		}
	}


	public class Shark : Fish
	{

	}

	public class Salmon : Fish
	{

	}
}
