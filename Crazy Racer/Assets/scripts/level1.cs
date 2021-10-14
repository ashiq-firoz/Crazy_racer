using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1 : MonoBehaviour
{
    void Start(){
        PlayerPrefs.SetInt("final_count",0);
        PlayerPrefs.SetInt("input",1); // for true 1 else 0
        Debug.Log(PlayerPrefs.GetInt("final_count"));
    }
    void OnCollisionEnter(Collision collision){
        PlayerPrefs.SetInt("final_count",PlayerPrefs.GetInt("final_count")+1);
        Debug.Log(PlayerPrefs.GetInt("final_count"));
        stop();
    }

    void stop(){
          PlayerPrefs.SetInt("input",1);
    }
}
