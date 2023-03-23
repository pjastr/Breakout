using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodstawaController : MonoBehaviour
{
    public float paddleSpeed = 1f;
    private Vector3 playerPos = new Vector3(0, -9f, 0);

    // Update is called once per frame
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f), -9f, 0);
        transform.position = playerPos;
    }
}
