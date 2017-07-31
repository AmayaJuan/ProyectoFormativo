using UnityEngine;
using System.Collections;

public class Destruir : MonoBehaviour 
{
	public GameObject manager;
	private Puntaje puntaje_script;

	void Start()
	{
		puntaje_script = manager.GetComponent<Puntaje> ();
	}

	void OnTriggerEnter2D (Collider2D collisionador)  
	{
		if (collisionador.gameObject.tag == "Player")
		{
			puntaje_script.GuardarPuntaje("Puntaje_Actual",(int)puntaje_script.puntajeGanado + 1);//Es igual que: PlayerPrefs.SetInt("Puntaje_Actual", (int)puntaje_script.puntajeGanado + 1);
			puntaje_script.CalcularPuntajeMayor((int)puntaje_script.puntajeGanado + 1);
			Application.LoadLevel(3);
		} 
		else 
		{
			if(collisionador.gameObject.transform.parent)
				Destroy(collisionador.gameObject.transform.parent.gameObject);
			else
				Destroy(collisionador.gameObject);
		}
	}
}
