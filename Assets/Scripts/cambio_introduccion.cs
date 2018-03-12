using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class cambio_introduccion : MonoBehaviour {

	public VideoPlayer Video;
	public string escena;
	public int rep;
	void Start (){
		Video = GetComponent<VideoPlayer> ();
		Video.Play ();

	}
	// Update is called once per frame
	void Update () {
		if (Video.isPlaying) {
			
			rep = 1;
		} 
		if (!Video.isPlaying && rep==1) {
			Application.LoadLevel(escena);
		} 


	}
}
