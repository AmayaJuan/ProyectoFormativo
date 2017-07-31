using UnityEngine;
using System.Collections;

public class PasarLogo : MonoBehaviour 
{
	void Start ()
	{
		StartCoroutine (PasarNivel());
	}
	
	IEnumerator PasarNivel()
	{
		yield return new WaitForSeconds (3f); 
		Application.LoadLevel(1);
	}

}
