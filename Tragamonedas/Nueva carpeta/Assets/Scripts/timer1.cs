using UnityEngine;
using System.Collections;

public class timer1 : MonoBehaviour {
	float timeRemaining = 20.0f;
	private int cont=0;
	public TextMesh tiempo;

	void init(){
		NotificationCenter.DefaultCenter ().PostNotification (this, "MoreCoins");
		timeRemaining = 20.0f;
	}
	void Update () {

		timeRemaining -= Time.deltaTime;
		cont= (int)timeRemaining;
		if(timeRemaining > 0){
			
			tiempo.text= cont.ToString();
			
		}
		else{
			tiempo.text= "Monedas";
			init();

			
		}

	
}
}