using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject EnemyDeathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 5;
    [SerializeField] int hit =3;



    ScoreBoard scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        AddNonTriggerBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
        
        
    }

    private void AddNonTriggerBoxCollider()
    {
        SphereCollider sphereCollider = gameObject.AddComponent<SphereCollider>();
        sphereCollider.radius = 1.5f;
        sphereCollider.isTrigger = false;
     
      
        
    }

    // Update is called once per frame


    void OnParticleCollision(GameObject other)
    {

        scoreBoard.ScoreHit(scorePerHit);
        hit--;
        if(hit <= 0)
        {
        KillEnemy();
        }
       

    }

    private void KillEnemy()
    {
        GameObject fx = Instantiate(EnemyDeathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}
