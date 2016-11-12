using UnityEngine;
using System.Collections;

public class loops : monoBehaviour {
public Light[] lights;

void Start(){
    for(int i = 0; i <lights.length; i++){
            light.intensity = 1;
    }
}

public bool wounded;

while(wounded){
	Debug.Log ("Oof I am hurt");
	wounded--;
}
}