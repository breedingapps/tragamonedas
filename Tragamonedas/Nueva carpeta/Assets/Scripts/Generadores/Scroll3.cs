using UnityEngine;
using System.Collections;

public class Scroll3 : MonoBehaviour {

		
		public bool IniciarEnMovimiento = false;
		public float velocidad = 0f;
		private bool enMovimiento = false;
		private float tiempoInicio = 0f;

		
		// Use this for initialization
		void Start () {
			NotificationCenter.DefaultCenter().AddObserver(this, "BotonPresionado");
		NotificationCenter.DefaultCenter().AddObserver(this, "scrollend");
		NotificationCenter.DefaultCenter().AddObserver(this, "scrollultimo");
			//if (IniciarEnMovimiento) {
			//	PersonajeEmpiezaACorrer();
			//}
		}
	/*void scrollultimo(){
		velocidad = 5f;
	}*/
	void scrollend(){
			enMovimiento = false;
		gameObject.SetActive (false);	
			
		}
		
		void BotonPresionado(){
			enMovimiento = true;
			tiempoInicio = Time.time;
		}
		
		// Update is called once per frame
		void Update () {
			if(enMovimiento){
				GetComponent<Renderer>().material.mainTextureOffset = new Vector4(((Time.time - tiempoInicio) * velocidad) % 1, 0);
			}
		}
	}
