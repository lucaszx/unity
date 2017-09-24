using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuegoControlador : MonoBehaviour {

	[Range(0f,0.20f)]
	public float parallaxSpeed = 0.04f;
	public RawImage fondo;
	public RawImage plataforma;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float finalSpeed = parallaxSpeed * Time.deltaTime;
		fondo.uvRect = new Rect(fondo.uvRect.x + finalSpeed, 0f, 1f, 1f);
		plataforma.uvRect = new Rect(plataforma.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
		
	}
}
