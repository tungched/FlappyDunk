using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRing : MonoBehaviour
{
    private float speed = 1f;

    

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        Invoke("Destroy", 3f);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
