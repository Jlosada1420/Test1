using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement2 : MonoBehaviour
{
    public Transform target;

    [SerializeField] private Vector3 offset;
    [SerializeField] private float followspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowTarget();
    }

    public void FollowTarget()
    {
        if (target != null)
        {
            var targetPos = target.position + offset;
            transform.position = targetPos;
        }
    }
}
