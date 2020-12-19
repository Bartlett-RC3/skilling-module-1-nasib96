using System;
using UnityEngine;

namespace Dog_Class
{


	public class Dog_Class_RC3
	{
		// Variable
	    string breed;
	    int lifeSpan;
	    float height;
	    string temperaments;
	    float minimumHeight;
	    MeshFilter shape;
	    MeshRenderer renderer;
	    Transform transform;
	    GameObject gameObject;
		public Color dogColor;
		Vector3 currentPos = new Vector3(0, 0, 0);
		Vector3 newPos = new Vector3();

		// Constructor
		public Dog_Class_RC3(string _breed , int _age)
		{
			breed = _breed;
			lifeSpan = _age;
			minimumHeight = 0.9f;
			height = ((lifeSpan /0.2f) + minimumHeight);
			//Intiate geometery
			GameObject Dog = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//Change Color
			Dog.GetComponent<Renderer>().material.color = this.dogColor;
			newPos = new Vector3(0, 0, lifeSpan * 2) + currentPos;
			Dog.transform.position = newPos;
			Dog.transform.localScale = new Vector3(Dog.transform.localScale.x * this.height/10,
												   Dog.transform.localScale.y * this.height/10,
												   Dog.transform.localScale.z * (this.height/20));
		}
		//Behaviour
		public String getBreed()
		{
			return breed;
		}
		public float getLifeSpan()
		{
			return lifeSpan;
		}
		public void getTemperaments(string _temperaments)
		{
			temperaments = _temperaments;
		}
		private void characters()
		{
			/*
			Maintenance Level
			Health Risk
			Abilities
			*/
		}
		public void Walking()
		{
			// Code for execution
		}
		public void Sleep()
		{
			// Code for execution
		}
		public void Bark()
		{
			// Code for execution
			Debug.Log("Woof Woof");
		}
		public void getHeight()
		{
			Debug.Log(height+ "=" + breed + " height in cm");
		}



	}
}

