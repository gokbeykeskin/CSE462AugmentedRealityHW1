using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugLog : MonoBehaviour
{
    public void TargetFound(){
        GetComponent<Text>().text = "TargetFound!";
    }
    public void TargetLost(){
        GetComponent<Text>().text = "TargetLost!";
    }
    public void ObjectPlaced(){
        GetComponent<Text>().text = "ObjectPlaced!";
    }
}
