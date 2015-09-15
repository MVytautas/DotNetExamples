using System;
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
        public Boolean Life { get; set; }

		public void Eat(string food)
		{
			//eat
		}
		public virtual void Move(string location)
		{
			//move
		}

	    public abstract Object Hunt();

		public abstract String Speak(); // abstract == required
	}

	public abstract class Mammal : Animal
	{
	    public override void Move(string location)
	    {
	        // walking
	    }
	}

    public abstract class Reptiles : Animal
    {
        public override void Move(string location)
        {
            // slide
        }

        public override string Speak()
        {
            return null;
        }
    }

    public abstract class Amphibians : Animal
    {
        public override void Move(string location)
        {
            // slide
        }

        public override string Speak()
        {
            return null;
        }
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

	public abstract class Bird : Animal
	{
        public override string Speak()
        {
            // warble    
			throw new NotImplementedException();
        }

	    public override void Move(string location)
	    {
	        // fly
	    }
	}

/// <summary>
/// HERE LISTING ALL ANIMALS BELOW
/// </summary>
	public class Cat : Mammal
	{
		public Int32 Lives = 9;

		public override String Speak()
		{
			return "Meow";
		}

    public override object Hunt()
    {
        throw new NotImplementedException();
    }
	}




	public class Dog : Mammal
	{
		public override String Speak()
		{
			return "Woof";
		}

	    public override object Hunt()
	    {
	        throw new NotImplementedException();
	    }
	}


	public class Shark : Fish
	{
	    public override object Hunt()
	    {
	        throw new NotImplementedException();
	    }
	}

	public class Salmon : Fish
	{
	    public override object Hunt()
	    {
	        throw new NotImplementedException();
	    }
	}

    public class Fog : Amphibians
    {
        public override object Hunt()
        {
            throw new NotImplementedException();
        }
    }
}
