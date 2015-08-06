using UnityEngine;
using System.Collections;

public class BotonEsperar : MonoBehaviour {
	public GameObject CameraNoCoins;
	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown(){
		CameraNoCoins.SetActive (false);
		}
	// Update is called once per frame
	void Update () {
	
	}
}
