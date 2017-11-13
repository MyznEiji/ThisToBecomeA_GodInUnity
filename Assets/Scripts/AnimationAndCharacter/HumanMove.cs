using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove : MonoBehaviour 
{
	Animator _a;
	void Start () 
	{
		_a = GetComponent<Animator>();
		_a.SetFloat("Forward",0f);
	}
	
	void Update () 
	{
		float speed = Input.GetAxis("Vertical");
		if(speed < 0) speed = 0;
		_a.SetFloat("Forward",speed);
	}
}
