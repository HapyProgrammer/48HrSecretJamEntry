using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// start with checking if any food is within eating range and start heading towards it or eat it
/// </summary>
public class HumanEat : MonoBehaviour {

	public float eatingRange;
	public float seesFoodRange;

	private HumanRepopulate repopulate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	public void FoodNearBy(Vector3 foodPosition)
	{

	}
}