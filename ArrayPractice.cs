using UnityEngine;
using System.Collections;

public class ArrayPractice : MonoBehaviour {




	string[] fellowship = { "Sam", "Frodo", "Gandalf" };
	public bool nightTime;
	public Light[] myLights;
	public float timer;
	private float timerSave;
	public Light Sun;
	public float sunSpeed;

	// Use this for initialization
	void Start () {
		timerSave = timer;
		print (fellowship [2]);

	}
	
	// Update is called once per frame
	void Update () {
		Sun.transform.Rotate (sunSpeed * Time.deltaTime, 0, 0);

		timer -= Time.deltaTime;
		if (timer < 0) {
			timer = timerSave;
			if (nightTime)
				nightTime = false;
			else
				nightTime = true;	
		}
		if (nightTime) {
			for (int i = 0; i < myLights.Length; i++) {
				myLights [i].intensity = 1;
			}
		}
			else if (!nightTime) {
			for (int i = 0; i < myLights.Length; i++) {
					myLights [i].intensity = 0;}
			}
	}
}
