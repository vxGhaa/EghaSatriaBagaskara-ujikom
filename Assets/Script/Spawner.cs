using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObjectsPrefab;
    private static readonly float _spawnLimitXLeft = -12;
    private static readonly float _spawnLimitXRight = 7;
    private static readonly float _spawnPosY = 1;

    private static readonly float _startDelay = 1.0f;
    private static readonly float _lifetime = 2.0f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandom), _startDelay, Random.Range(1.0f, 2.0f));
    }

    void SpawnRandom()
    {
        Vector3 spawnPos = new Vector3(Random.Range(_spawnLimitXLeft, _spawnLimitXRight), _spawnPosY, 0);

        int objectindex = Random.Range(0, ObjectsPrefab.Length);
        GameObject animal = Instantiate(ObjectsPrefab[objectindex], spawnPos, ObjectsPrefab[0].transform.rotation);

        Destroy(animal, _lifetime);
    }
}
