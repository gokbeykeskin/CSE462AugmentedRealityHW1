using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
public class VirtualButton : MonoBehaviour
{
    [SerializeField] int sceneIndex;
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        SceneManager.LoadScene(sceneIndex);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){

    }


}
