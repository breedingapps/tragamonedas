using UnityEngine;
using System.Collections;

public class suma : MonoBehaviour {
	private int a=2;
	private int b=3;
	private int c= 0;
	private int d= 10;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "Figura1A5");
		c = a * b;
		Debug.Log (c);

	}

	void Figura1A5(){
		d = d + c;
		Debug.Log (d);
	}

	
	// Update is called once per frame
	void Update () {

	}
}
