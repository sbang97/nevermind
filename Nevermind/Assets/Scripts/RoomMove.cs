using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    public Vector2 cameraChange;
    public Vector2 newMin;
    public Vector2 newMax;
    public Vector3 playerChange;
    private CameraMovement cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cam.minPosition = newMin + cameraChange;
            cam.maxPosition = newMax + cameraChange;
            other.transform.position += playerChange;
        }
    }
}
