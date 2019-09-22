using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{


    [SerializeField] private Transform target; //alvo
    [SerializeField] private float force; // movement
    [SerializeField] private float rotationForce;
    [SerializeField] private float secondsBeforeHoming;
    [SerializeField] private float launchForce;
    private Rigidbody rb;
    private bool follow = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(waitBeforeHoming());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        if (follow == true)
        {
            if (target != null)
            {
                MissileGuidance();
            }
        }
         
        
    }

    private void MissileGuidance()
    {
        Vector3 direction = target.position - rb.position; // direção
        direction.Normalize(); //correção da direção
        Vector3 rotationAmount = Vector3.Cross(transform.forward, direction); // calculo de rotaçao
        rb.angularVelocity = rotationAmount * rotationForce; // rotação
        rb.velocity = transform.forward * force; //velocidade
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.collider.gameObject);
        Destroy(gameObject);
    }

    private IEnumerator waitBeforeHoming()
    {
        rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);
        yield return new WaitForSeconds(secondsBeforeHoming);
        follow = true;
    }



}
