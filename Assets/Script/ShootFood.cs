using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFood : MonoBehaviour
{
    public GameObject Food;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject food = Instantiate(Food, transform.position, Food.transform.rotation);
            Destroy(food, 3f);

        }
    }
}
