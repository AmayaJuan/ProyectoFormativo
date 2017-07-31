using UnityEngine;
using System.Collections;

/// <summary>
/// Control camara.Este codigo la camara persigue al jugador
/// </summary>

public class ControlCamara : MonoBehaviour 
{
	public GameObject jugador;

	void Update () 
	{
		transform.position = new Vector3 (jugador.transform.position.x + 5, transform.position.y, transform.position.z);
	}
}
