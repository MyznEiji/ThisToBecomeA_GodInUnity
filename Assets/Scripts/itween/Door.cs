using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	bool opn = false;
	//void Start () 
	//{
	//	
	//}
	
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			DoorOpen();
		}
	}

	void DoorOpen()
	{
		opn = !opn;
		if(opn)
		{
			RotateJoint(30f,"easeOutBack");
		}
		else 
		{
			RotateJoint(0f,"easeInQuad");
		}
	}

	void RotateJoint(float x,string y)
	{
		iTween.RotateTo
		(
			gameObject,
			iTween.Hash("y",x,"islocal",true,"easetype",y)
		);
	}
}
