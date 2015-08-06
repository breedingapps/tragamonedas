using UnityEngine;
using System.Collections;

public class BC4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BC4");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
