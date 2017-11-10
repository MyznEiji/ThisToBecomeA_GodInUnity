using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTofu : MonoBehaviour 
{
	[SerializeField] private GameObject tofu;
	float time = 0;
	int tofuCount = 0;
	void Update () 
	{
		time += Time.deltaTime;
		if(time > 2.0f && tofuCount <= 100)
		{
			InstantiateTofu();
		}
	}

	void InstantiateTofu()
	{
		//100個のtofuを生成
		Instantiate(tofu,Vector3.up * 5,Quaternion.identity);
		tofuCount ++;
		time = 0;
	}
}
