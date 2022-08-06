using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;
    [SerializeField] Color32 customerColor = new Color32(1,1,1,1);

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPackage == false)
        {
            hasPackage = true;
            Destroy(other.gameObject);
            
        }

        if(other.tag == "Customer" && hasPackage )
        {
            hasPackage = false;
            spriteRenderer.color = customerColor;
            
        }
        
    }
}
