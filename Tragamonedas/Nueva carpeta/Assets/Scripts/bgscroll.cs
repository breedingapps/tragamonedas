using UnityEngine;
using System.Collections;

public class bgscroll : MonoBehaviour {

	public bool IniciarEnMovimiento = false;
	public float velocidad = 0f;
	private bool enMovimiento = false;
	private float tiempoInicio = 0f;
	
	
	// Use this for initialization
	void Start () {
		enMovimiento = true;
		//if (IniciarEnMovimiento) {
		//	PersonajeEmpiezaACorrer();
		//}
	}




	
	
	// Update is called once per frame
	void Update () {
		if(enMovimiento){
			GetComponent<Renderer>().material.mainTextureOffset = new Vector4(((Time.time - tiempoInicio) * velocidad) % 1, 0);
		}
	}
}
