using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tarret : MonoBehaviour 
{
	[SerializeField] private GameObject bullet,muzzle;
	[SerializeField] private GameObject shotSpark;

	void Start () 
	{
	}

	
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Fire();
		}
		
	}

	void Fire()
	{
		Instantiate(bullet,muzzle.transform.position + new Vector3(0.5f,0.5f,0),transform.rotation);
		Instantiate(shotSpark,muzzle.transform.position,transform.rotation);
	}
}
