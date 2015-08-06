using UnityEngine;
using System.Collections;

public class F1C3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "F1C3");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
