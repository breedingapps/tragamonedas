using UnityEngine;
using System.Collections;

public class GC3 : MonoBehaviour {

	public GameObject[] obj;
	private bool BonusActive=false;
	//public float tiempoMin = 1.25f;
	//public float tiempoMax = 2.5f;
	private bool fin = false;
	
	
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "DBC3");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPresionadoDeNuevo");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BotonPresionado");
		NotificationCenter.DefaultCenter().AddObserver(this, "Generador3");
		
	}
	void DBC3(){
		BonusActive = true;
	}
	void Generador3 (){
		fin = false;
		Invoke ("Generar", 1.0f);
	}
	void BotonPresionado(){
		fin = true;
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	void Volver(){
		fin = true;
		BonusActive = false;
	}
	void Generar(){
		if(!fin){
			if(BonusActive){
			Instantiate(obj[Random.Range(0,obj.Length)],transform.position, Quaternion.identity);

			}else{
				Instantiate(obj[Random.Range(0,7)],transform.position, Quaternion.identity);
				Debug.Log("no");
			}
				NotificationCenter.DefaultCenter().PostNotification(this, "PayLineCheck");
			NotificationCenter.DefaultCenter().PostNotification(this, "Generador4");
			NotificationCenter.DefaultCenter().PostNotification(this, "Parallax3");
			Volver();
		}
		
	}
	
}
