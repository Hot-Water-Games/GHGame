using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMove : MonoBehaviour
{

    public float speed = 10f;
    public GameObject bullet;
    public float bulletThreshold = 0.1f;
    float elapsedTime = 0;
    public shipGame control;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
        transform.Translate(Input.acceleration.x * speed * Time.deltaTime, 0f, 0f);

        if (Input.GetButtonDown("Jump") || Input.touches.Length >0)
        {
            if(elapsedTime > bulletThreshold)
            {
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 1.2f, -6f), Quaternion.identity);

                elapsedTime = 0f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
