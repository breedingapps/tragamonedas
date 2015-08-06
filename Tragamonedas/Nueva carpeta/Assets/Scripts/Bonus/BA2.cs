using UnityEngine;
using System.Collections;

public class BA2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BA2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
