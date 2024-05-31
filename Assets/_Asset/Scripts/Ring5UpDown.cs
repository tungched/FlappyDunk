using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring5UpDown : MonoBehaviour
{
    public float speed = 2.0f; 
    [SerializeField] private float maxHeight = 2.0F;
    [SerializeField] private float minHeight = -2.0f; 

    private bool movingUp = true;

    void Update()
    {
        
        if (movingUp)
        {
            //Di chuyển theo hướng up, cục bộ của vật
            transform.Translate(Vector3.up * speed * Time.deltaTime);

            // Kiểm tra điều kiện moving
            if (transform.position.y >= maxHeight)
            {
                movingUp = false;
            }
        }
        else
        {           
            transform.Translate(Vector3.down * speed * Time.deltaTime);
          
            if (transform.position.y <= minHeight)
            {
                movingUp = true;
            }
        }
    }

}
