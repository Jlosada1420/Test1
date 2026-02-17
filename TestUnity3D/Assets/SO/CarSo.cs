using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Car", menuName ="Car/New Car")]
public class CarSo : ScriptableObject
{
    public float speed;
    public float brake;
    public float angle;
}
