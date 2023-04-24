using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position +  (new Vector3(-horizontalInput, 0, -verticalInput) * moveSpeed * Time.deltaTime);
        
    }
}
