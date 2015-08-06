using UnityEngine;
using System.Collections;

public class F5B5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "F5B5");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
