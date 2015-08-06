using UnityEngine;
using System.Collections;

public class GB4 : MonoBehaviour {

	public GameObject[] obj;
	private bool BonusActive= false;
	//public float tiempoMin = 1.25f;
	//public float tiempoMax = 2.5f;
	private bool fin = false;
	
	
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "DBB4");
		NotificationCenter.DefaultCenter().AddObserver(this, "BotonPresionadoDeNuevo");
		NotificationCenter.DefaultCenter ().AddObserver (this, "BotonPresionado");
		NotificationCenter.DefaultCenter().AddObserver(this, "Generador4");
		
	}
	void DBB4(){
		BonusActive = true;
	}
	void Generador4 (){
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
				Instantiate(obj[Random.Range(0,7)],transform.position,Quaternion.identity );

			}
				NotificationCenter.DefaultCenter().PostNotification(this, "PayLineCheck");
			NotificationCenter.DefaultCenter().PostNotification(this, "Generador5");
			NotificationCenter.DefaultCenter().PostNotification(this, "Parallax4");

			Volver();
		}
		
	}
	
}
