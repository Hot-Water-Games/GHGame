using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    float spawnThreshold = 100;
    float spawnDecrement = .1f;

    public GameObject meteor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0, spawnThreshold) <=1)
        {
            Vector3 pos = transform.position;
            Instantiate(meteor, new Vector3(pos.x + Random.Range(-3, 4), pos.y, pos.z), Quaternion.identity);

            spawnThreshold -= spawnDecrement;
            if(spawnThreshold <2)
            {
                spawnThreshold = 2;
            }
        }
    }
}
