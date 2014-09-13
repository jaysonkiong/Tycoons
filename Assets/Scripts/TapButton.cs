using UnityEngine;
using System.Collections;

public class TapButton : MonoBehaviour 
{
	void OnMouseDown ()
	{
		Debug.Log ("I Pressed the " + gameObject.name);

		switch (gameObject.name) 
		{
		case "Home":
			Debug.Log("HOME TO!:");
			break;
		case "Market":
			Debug.Log("MARKET TO!");
			break;
		case "Property":
			Debug.Log("PROPERTY TO!");
			break;
		case "Upgrades":
			Debug.Log("UPGRADES TO!");
			break;
		default:
			Debug.Log("HOME TO");
			break;
		}
	}
}
