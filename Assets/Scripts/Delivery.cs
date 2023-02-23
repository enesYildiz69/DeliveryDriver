using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 hasPackageColor = new Color32 (1, 255, 1, 255);
    [SerializeField] private Color32 noPackageColor = new Color32 (255, 1, 52, 255);

    SpriteRenderer spriteRenderer;
    private int PackageCount = 0;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("You crashed!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package")
            if (PackageCount == 0) {
                PackageCount ++ ;
                spriteRenderer.color = hasPackageColor;
                Debug.Log("Package picked!");
                Destroy(other.gameObject,0);
            }
            else
                Debug.Log("Deliverer full!");
        else if (other.tag == "Customer")
            if (PackageCount != 0) {
                PackageCount = 0 ;
                spriteRenderer.color = noPackageColor;
                Debug.Log("Package delivered!");
            }
            else
                Debug.Log("There is no package to deliver");
    }
}
