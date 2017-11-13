using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour 
{
	Animator _a;
	bool mouseOn = false;

	void Start () 
	{
		_a = GetComponent<Animator>();
		Debug.Log("色が変化している時にspaceKeyを押すとscaleが変化する");
	}
	
	void Update () 
	{
		if(Input.GetKey("space"))
		{
			mouseOn = !mouseOn;
			_a.SetBool("MouseOn",mouseOn);	
		}
		
	}
}
