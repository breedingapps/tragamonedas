using UnityEngine;
using System.Collections;

public class BB1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BB1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
