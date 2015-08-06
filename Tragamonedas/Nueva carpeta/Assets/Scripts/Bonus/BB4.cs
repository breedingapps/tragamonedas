using UnityEngine;
using System.Collections;

public class BB4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BB4");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
