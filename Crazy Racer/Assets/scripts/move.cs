using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform cam;
    public float speed = 10; 
    void Update()
    {
        
        cam.position = this.transform.position;
        
        if(PlayerPrefs.GetInt("input")==1){

        if(Input.GetKey(KeyCode.UpArrow)){ // checks if uparrow is pressed
            this.transform.Translate(Vector3.forward*speed*Time.deltaTime);      // Change 10 to speed for the below code
        }
        if(Input.GetKey(KeyCode.DownArrow)){ // checks if downarrow is pressed
            this.transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){ // checks if leftarrow is pressed
            //this.transform.Translate(Vector3.left*10*Time.deltaTime);
            this.transform.Rotate(-Vector3.up*38*Time.deltaTime);
            cam.Rotate(-Vector3.up*38*Time.deltaTime);
           
        }
        if(Input.GetKey(KeyCode.RightArrow)){ // checks if rightarrow is pressed
            //this.transform.Translate(Vector3.right*10*Time.deltaTime); 
            this.transform.Rotate(Vector3.up*38*Time.deltaTime);
            cam.Rotate(Vector3.up*38*Time.deltaTime);
                
        }
        }
        
    }
}
