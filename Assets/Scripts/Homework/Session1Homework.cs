using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour 
{
	//Section 1...............................................................................................................
	//Numbers
	public int wholeNumberA = 2;
	public int wholeNumberB = 4;
	public float decimalNumberOne = 1.5f;
	public double lDecimalNumberX = 1.95555555555555555555555555d;
	//Text
	public string firstWord = "Welcome";
	private string secondWord = "This is a private string";
	//Logical
	public bool proceed = true;
	public bool yes = false;
	//Array
	public string[] wordSet = new string[3];
	public int[] numberSet = { 1, 5, 7, 9 };
	//List
	public List<int> numberList = new List<int>();
	//Function
	private int SumCalculator(int _NumberX, int _NumberY)
	{
		int SumResult = _NumberX + _NumberY;
		return SumResult;
	}
	//Dictionary
	IDictionary<char, string> firstDictionary = new Dictionary<char, string>();

	//Section 2...............................................................................................................
	// Loop
	string[] birds = { "Eagle", "Hawk", "Raven", "Sparrow" };
	// Use this for initialization
	void Start ()
	{
		//Section 1...............................................................................................................
		Debug.Log(SumCalculator(wholeNumberA, wholeNumberB));

		// Dictionary
		firstDictionary.Add('A', "Ant Apple Arrow");
		firstDictionary.Add('B', "Ball Bat Basket");
		firstDictionary.Add('C', "Cat Column Container");
		firstDictionary.Add('D', "Dates Diamond Dove");
		Debug.Log(firstDictionary['C']);
		firstDictionary['B'] = "Bird Bow Balloon";
		Debug.Log(firstDictionary['B']);

		//Section 2...............................................................................................................
		for (int Counter = 0; Counter < birds.Length; Counter++)
		{
			Debug.Log("Position of" + " " + birds[Counter]);
			Debug.Log(Counter);
		}

		int sumOfEvenNumbers = 0;
		for (int i = 2; i < 200; i = i + 2)
		{
			sumOfEvenNumbers += i;
		}
		Debug.Log("Total" + " " + sumOfEvenNumbers);

		foreach (string wings in birds)
		{
			Debug.Log("Free the" + " " + wings);
		}
		//While loop, Always mention the end condition
		int birdCounter = 0;
		string birdPark = " birds in the cage";
		while (birdCounter < birds.Length)
		{
			birdPark += " " + birdCounter + birds[birdCounter] + ",";
			birdCounter += 2;
		}
		Debug.Log(birdPark);
		
		//Conditionals
		for(int i=0; i<100; i+=3)
        {
			if (i%2 == 1)
            {
				Debug.Log(i + " is an Odd Number");
            }
			else
            {
				Debug.Log(i + " is an Even number");
            }
        }

		//Multiple question
		bool aOne = true;
		bool aTwo = false;
		bool aThree = true;

		if (aOne && aTwo)
        {
			Debug.Log("aOne and aTwo is correct");
        }
		else
        {
			Debug.Log(" Conditions not met");
        }

		if(aOne && aThree)
        {
			if(aOne || aTwo)
            {
				if (aTwo == true)
                {
					Debug.Log("OK");
                }
				else
                {
					Debug.Log("aTwo is False");
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
