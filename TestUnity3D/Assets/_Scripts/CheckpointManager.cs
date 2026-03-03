using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{

    [HideInInspector] public Transform checkpoint;
    public Transform startPos;

    // Start is called before the first frame update
    void Start()
    {
        checkpoint = startPos; 
    }

    // Update is called once per frame
    void Update()
    {
        CarReset();
    }

    //Metodo para resetear el carro
    public void CarReset()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.position = checkpoint.position;
            transform.rotation = checkpoint.rotation; 
        }
    }
    
}
