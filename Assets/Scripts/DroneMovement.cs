using UnityEngine;
using System.Collections;
 
public class DroneMovement : MonoBehaviour {

        [SerializeField] Transform ARCam;


    void Update(){
        transform.position = Vector3.MoveTowards(transform.position,ARCam.position,1f*Time.deltaTime);
    }


}
