using UnityEngine;
using System.Collections;

public class BotonPL2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		NotificationCenter.DefaultCenter().PostNotification(this, "BotonPL2");
		
		
	}
}
