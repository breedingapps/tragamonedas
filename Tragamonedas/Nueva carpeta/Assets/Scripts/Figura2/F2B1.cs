using UnityEngine;
using System.Collections;

public class F2B1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "F2B1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
