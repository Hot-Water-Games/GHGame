using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletsc : MonoBehaviour
{
    float speed = 10f;
    shipGame control;

    // Start is called before the first frame update
    void Start()
    {
        control = GameObject.Find("GameControl").GetComponent<shipGame>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        control.AddScore();
        Destroy(this.gameObject);
    }
}
