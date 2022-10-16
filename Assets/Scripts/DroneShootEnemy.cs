using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneShootEnemy : MonoBehaviour
{
    [SerializeField] float shootRate;
    private float m_shootRateTimeStamp;
    Transform enemy=null;
    [SerializeField] GameObject m_shotPrefab;
    [SerializeField] Transform ARCam;
    [SerializeField] Transform[] enemies;
    [SerializeField] float shootDistance;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Enemy"){
            enemy = other.transform;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag=="Enemy") enemy=null;
    }
    
    void Update()
    {
        foreach(var enemy in enemies){
            if(enemy!=null && Vector3.Distance(ARCam.position,enemy.position)<shootDistance && Time.time > m_shootRateTimeStamp){
                Shoot(enemy.position);
                Destroy(enemy.gameObject);
                m_shootRateTimeStamp = Time.time + shootRate;
            }

        }

    }

    void Shoot(Vector3 enemyPos){
            Debug.Log("CCC");
            GameObject laser = GameObject.Instantiate(m_shotPrefab, transform.position, transform.rotation) as GameObject;
            laser.GetComponent<ShotBehavior>().setTarget(enemyPos);
            GameObject.Destroy(laser, 2f);
    }
}
