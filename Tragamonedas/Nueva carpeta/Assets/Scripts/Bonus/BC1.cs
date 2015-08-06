using UnityEngine;
using System.Collections;

public class BC1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BC1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
