using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;
namespace SuperHerosummer2020
{
	public class Superero
	{
		//Fields 
		private bool hasCape;
		private int speed;
		private string name;

		////Property Declaration using Getter and setter Methods on the Private Fields
		//public bool HasCape
		//{
		//	get { return this.hasCape; }
		//	set { this.hasCape = value; }
		//}
		//public int Speed
		//{
		//	get { return this.speed; }
		//	set { this.speed = value; }
		//}
		//public string Name
		//{
		//	get { return this.name; }
		//	set { this.name = value; }
			
		//}
			

		//CLASS PROPERTIES
		// Or .. Shorthand Property Declaration

		public bool HasCape { get; set; }
		public int Speed { get; set; }
		public string Name { get; set; }
		
		// CLASS CONSTRUCTORS
		//this is a default constructor (NAME IS GIVEN)

		//public SuperHero()
		//{

		//}

		
		public void SuperHero (string name)
		{
			Name = name;
		}

		//CLASS METHODS (CAN CHANGE HEROS NAME)
		public void AssignName(string nameThatWasPsssedIn)
		{
			Name = nameThatWasPsssedIn;
		}

		public void IncreaseSpeed (int increaseInSpeed)
		{
			Speed = Speed + increaseInSpeed;
		}

		public string GreatSuperHero ()
		{
			return "Hello, my favorite fan!";
		}


		
	}
}


	