using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpark : MonoBehaviour 
{
	void Start () 
	{
		Invoke("Death",2f);
	}
	void Death()
	{
		Destroy(gameObject);
	}
	
	//void Update () 
	//{
	//	
	//}
}
