using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{

    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] float speedUp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost") {
            moveSpeed += speedUp;
            Debug.Log("Boost picked!");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float steerHorizontal = Input.GetAxis("Horizontal");
        float steerVertical = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -steerHorizontal * steerSpeed * Time.deltaTime) ;
        transform.Translate(0, moveSpeed * steerVertical * Time.deltaTime, 0);
    }
}
