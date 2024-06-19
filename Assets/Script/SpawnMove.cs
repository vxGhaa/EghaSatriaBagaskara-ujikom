using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class SpawnMove : MonoBehaviour
{
    public float Speed;
    void Update()
    {
        transform.Translate(Vector3.forward * (Speed * Time.deltaTime));
    }
}
