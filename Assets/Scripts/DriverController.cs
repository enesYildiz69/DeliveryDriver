using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{

    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerHorizontal = Input.GetAxis("Horizontal");
        float steerVertical = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -steerHorizontal * steerSpeed * Time.deltaTime) ;
        transform.Translate(0, moveSpeed * steerVertical * Time.deltaTime, 0);
    }
}
