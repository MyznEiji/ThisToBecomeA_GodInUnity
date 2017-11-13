using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hogehogeLight : MonoBehaviour 
{
	public float lightIntensity = 0.2f;
	Light myLight;
	void Start () 
	{
		myLight = GetComponent<Light>();
		myLight.intensity = 3;
	}
	
	void Update () 
	{
		myLight.intensity = lightIntensity;	
	}
}
