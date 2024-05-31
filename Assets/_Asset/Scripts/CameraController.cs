using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Camera property
    [SerializeField] private float speed;
    private Vector3 velocity = Vector3.zero;

    //Follow player
    [SerializeField] private Transform BallPlayer;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;

    private void Update()
    {
        transform.position = new Vector3(BallPlayer.position.x + lookAhead, transform.position.y, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * BallPlayer.localScale.x), Time.deltaTime * cameraSpeed);
    }
}
