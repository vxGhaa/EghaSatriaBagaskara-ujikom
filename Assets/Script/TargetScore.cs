using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScore : MonoBehaviour
{
    public int PointValue;

    // void Start()
    // {

    // }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if( )
    // }

    public ParticleSystem destroyParticle;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(destroyParticle.gameObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
