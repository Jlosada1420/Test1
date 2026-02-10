using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTrigger : MonoBehaviour
{
    public Material secondMaterial;  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pine"))
        {
            collision.gameObject.GetComponent<Renderer>().material = secondMaterial;
            collision.gameObject.transform.localScale = new Vector3(5, 5, 5);
        }
    }
}

