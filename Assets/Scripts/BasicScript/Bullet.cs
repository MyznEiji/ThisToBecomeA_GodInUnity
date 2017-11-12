using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	
	void Start () 
	{
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.up * 30,ForceMode.VelocityChange);
	}
	
	void Update () 
	{
	}
}
