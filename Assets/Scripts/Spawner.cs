using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = 1;
    float timer;
    
    void Update()
    {
        if (timer > beat)
        {
            timer -= beat;

            GameObject c = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
            c.transform.localPosition = Vector3.zero;
            c.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
        }
        timer += Time.deltaTime;
    }
}
