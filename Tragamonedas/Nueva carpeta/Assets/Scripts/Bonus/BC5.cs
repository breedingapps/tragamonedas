using UnityEngine;
using System.Collections;

public class BC5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BC5");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
