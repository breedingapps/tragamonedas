using UnityEngine;
using System.Collections;

public class BA3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BA3");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
