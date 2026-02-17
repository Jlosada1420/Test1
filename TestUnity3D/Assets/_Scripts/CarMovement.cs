using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private OldInput oldInput;

    public CarSo car;

    [SerializeField] private WheelCollider[] _wheelCollider;
    [SerializeField] private Transform[] _wheeltransform;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        oldInput = GetComponent<OldInput>();
        speed = car.speed;
    }

    // Update is called once per frame
    void Update()
    {
        WheelBrake();
        WheelsUpdate();
    }

    void FixedUpdate()
    {
        MotorSpeed();
        WheelAngle();
    }

    //Velocidad
    public void MotorSpeed()
    {
        foreach (var wheel in _wheelCollider) 
        {
            wheel.motorTorque = oldInput.vertical * car.speed;
        }
    }

    //Freno
    public void WheelBrake()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var wheel in _wheelCollider) 
            {
                wheel.brakeTorque = car.brake;
            }     
                  
        }else if (Input.GetKeyUp(KeyCode.Space))
        {
            foreach (var wheel in _wheelCollider) 
            {
                wheel.brakeTorque = 0;
            }   
        }
    }

    //Angulo
    public void WheelAngle()
    {
        _wheelCollider[2].steerAngle = oldInput.horizontal * car.angle;
        _wheelCollider[3].steerAngle = oldInput.horizontal * car.angle;
    }

    //Actualizar las llantas
    public void WheelsUpdate()
    {
        for(int i = 0; i<_wheelCollider.Length; i++)
        {
            UpdateWheel(_wheelCollider[i], _wheeltransform[i]);
        }
    }
    
    //Constructor Metodo
    public void UpdateWheel (WheelCollider collider, Transform transform)
    {
        Vector3 pos;
        Quaternion rot;

        //Obtener posicion y rotacion de los colliders
        collider.GetWorldPose(out pos, out rot);

        transform.position = pos;
        transform.rotation= rot;
    }

}
