using UnityEngine;
using System.Collections;

public class SampleScrollList : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.touchCount > 0) 
		{
			Vector2 pos = transform.position;
			pos.y += Input.GetTouch (0).deltaPosition.x;
			transform.position = pos;
		}
	}
}
