using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPresionado");
	}
	void BotonPresionado(){
		DestroyObject (gameObject);
		}
	// Update is called once per frame
	void Update () {
	
	}
}
