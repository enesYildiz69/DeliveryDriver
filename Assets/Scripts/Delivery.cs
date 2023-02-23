using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private int PackageCount = 0;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("You crashed!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package")
            if (PackageCount == 0) {
                PackageCount ++ ;
                Debug.Log("Package picked!");
                Destroy(other.gameObject,0);
            }
            else
                Debug.Log("Deliverer full!");
        else if (other.tag == "Customer")
            if (PackageCount != 0) {
                PackageCount = 0 ;
                Debug.Log("Package delivered!");
            }
            else
                Debug.Log("There is no package to deliver");
        else
            Debug.Log("Boost picked!");
    }
}
