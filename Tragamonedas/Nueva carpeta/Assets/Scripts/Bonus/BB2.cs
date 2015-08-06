using UnityEngine;
using System.Collections;

public class BB2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BB2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
