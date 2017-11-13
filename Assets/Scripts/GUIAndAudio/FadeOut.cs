using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour 
{
	public float speed = 0.01f; //透明化の速さ
	float alfa;
	float red,green,blue;
	Color color;
	void Start () 
	{
		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;
		color = GetComponent<Image>().color; 
	}
	
	void Update () 
	{
		GetComponent<Image>().color = new Color(red,green,blue,alfa);
		alfa += speed;	
	}
	// IEnumerator ChangeColor()
	// {	
	// 	while(true)
	// 	{
	// 		color = new Color(red,green,blue,alfa);
	// 		alfa -= speed;
	// 		yield return alfa == 0;
	// 	}

	// 	color = new Color(red,green,blue,alfa);
	// 	alfa += speed;
	// }
}
