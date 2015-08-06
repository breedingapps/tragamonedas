using UnityEngine;
using System.Collections;

public class BC2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BC2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
