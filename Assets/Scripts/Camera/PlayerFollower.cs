using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{

    [SerializeField] private PlayerController Car;
    
    void Update()
    {
        transform.position = Car.transform.position + new Vector3(0.3f, 7.5f, -8);
    }
}
