using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton : MonoBehaviour
{
    public static MonoSingleton instance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
