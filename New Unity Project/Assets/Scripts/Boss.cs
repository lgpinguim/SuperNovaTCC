using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
  
    [SerializeField] GameObject EnemyDeathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerHit = 5;
    [SerializeField] int scoreOnDeath = 500;
    [SerializeField] int hits = 50;


    ScoreBoard scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        AddBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();


    }

    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
     



    }

    // Update is called once per frame


    void OnParticleCollision(GameObject other)
    {

        scoreBoard.ScoreHit(scorePerHit);
        hits--;
        if (hits <= 1)
        {
        KillBoss();
        }
       

    }

    private void KillBoss()
    {
        scoreBoard.ScoreHit(scoreOnDeath);
        GameObject fx = Instantiate(EnemyDeathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
    }
}


// Update is called once per frame


