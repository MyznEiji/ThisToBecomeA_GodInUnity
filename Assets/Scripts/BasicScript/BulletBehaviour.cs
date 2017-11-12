using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour 
{
	public GameObject explosionPrefab;
	//void Start () 
	//{
	//	
	//}
	
	void Update () 
	{
			
	}
	void OnCollisionEnter(Collision col)
	{
		Instantiate(explosionPrefab,transform.position,transform.rotation);
		Destroy(gameObject);
		
	}
}
