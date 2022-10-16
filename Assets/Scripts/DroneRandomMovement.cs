using UnityEngine;
using System.Collections;
 
public class DroneRandomMovement : MonoBehaviour {
        float randX;
        float randY;
        float randZ;
        Vector3 startPos;
        [SerializeField] Transform ARCam;
    void Awake()
    {
        startPos = transform.position;
        StartCoroutine(MoveTowards());
    }

    void Update(){
        transform.position = Vector3.MoveTowards(transform.position,ARCam.position,1f*Time.deltaTime); 
    }

    IEnumerator MoveTowards()
    {

        while(true){
            randX = Random.Range(-0.1f,0.1f);
            randZ = Random.Range(-0.1f,0.1f);
            yield return new WaitForSeconds(1.5f);
        }
        
    }
}
