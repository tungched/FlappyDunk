using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapFlappyMoving : MonoBehaviour
{
    [SerializeField] private float velocity;
    //private float velocity = 2.5f;
    public Rigidbody2D rigid2D;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigid2D.velocity = Vector2.up * velocity;
        }
    }
}
