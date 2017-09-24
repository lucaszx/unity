using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuegoControlador2 : MonoBehaviour {

	[Range(0f,0.20f)]
	public float parallaxSpeed = 0.06f;
	public RawImage fondo2;
	public RawImage plataforma2;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float finalSpeed = parallaxSpeed * Time.deltaTime;
		fondo2.uvRect = new Rect(fondo2.uvRect.x + finalSpeed, 0f, 1f, 1f);
		plataforma2.uvRect = new Rect(plataforma2.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);

	}
}
