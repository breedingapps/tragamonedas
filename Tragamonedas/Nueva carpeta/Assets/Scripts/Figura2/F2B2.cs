using UnityEngine;
using System.Collections;

public class F2B2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "F2B2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
