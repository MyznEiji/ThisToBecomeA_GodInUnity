using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomRotate : MonoBehaviour 
{
	Vector3 rValue = Vector3.zero;
	public Color[] cList;
	void Start () 
	{
		Invoke("ChangeState",1f);
	}
	
	void Update () 
	{	
		transform.Rotate(rValue);
	}

	void ChangeState()
	{
		RotateChange();
		ColorChange();
		Invoke("ChangeState",Random.Range(1f,2f));
	}
	void RotateChange()
	{
		float rX = Random.Range(-1f,1f);
		float rY = Random.Range(-1f,1f);
		float rZ = Random.Range(-1f,1f);
		rValue = new Vector3(rX,rY,rZ);
	}

	void ColorChange()
	{
		int rColorIndex = Random.Range(0,cList.Length -1);
		GetComponent<MeshRenderer>().material.color = cList[rColorIndex];
	}
}
