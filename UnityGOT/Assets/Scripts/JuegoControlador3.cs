using System.Collections;
using System.Collections.Generic;
using UnityEngine;                  //Este script controla todas las funcionalidades generales del juego
using UnityEngine.UI;           //importamos UnityEngine.UI para utilizar componentes de interfaz


public class JuegoControlador3 : MonoBehaviour {
    [Range(0f, 0.20f)]
    public float parallaxSpeed = 0.08f;
    public RawImage fondo3;                             //definimos variables publicas para gestionar 
    public RawImage plataforma3;                       //tanto la velocidad del fondo como la plataforma y ademas para
	// Use this for initialization                    // importar estos componentes y utilizarlos en este Script
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float finalSpeed = parallaxSpeed * Time.deltaTime;
        fondo3.uvRect = new Rect(fondo3.uvRect.x + finalSpeed,0f,1f,1f);
        plataforma3.uvRect = new Rect(plataforma3.uvRect.x + finalSpeed*12, 0f, 1f, 1f);
    }
}
