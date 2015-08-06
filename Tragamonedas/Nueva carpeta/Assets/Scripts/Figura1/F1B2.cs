using UnityEngine;
using System.Collections;

public class F1B2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "F1B2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
