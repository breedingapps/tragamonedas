using UnityEngine;
using System.Collections;

public class Scroll2 : MonoBehaviour {

		
		public bool IniciarEnMovimiento = false;
		public float velocidad = 0f;
		private bool enMovimiento = false;
		private float tiempoInicio = 0f;

		
		// Use this for initialization
		void Start () {
			NotificationCenter.DefaultCenter().AddObserver(this, "BotonPresionado");
		NotificationCenter.DefaultCenter().AddObserver(this, "scrollultimo");
		NotificationCenter.DefaultCenter().AddObserver(this, "scrollmedio");
			//if (IniciarEnMovimiento) {
			//	PersonajeEmpiezaACorrer();
			//}
		}
	/*void scrollmedio(){
		velocidad = 5f;
	}*/
		void scrollultimo(){
			enMovimiento = false;
		NotificationCenter.DefaultCenter ().PostNotification (this, "scrollend");
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
