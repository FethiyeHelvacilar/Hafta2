using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;

    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;



    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput * verticalInput);

        if (transform.position.y < -4)
        {
            loseScreen.SetActive(true);
        }
        else if(transform.position.z > 120)
        {
            winScreen.SetActive(true);
        }
    }
    public void PlayAgain()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        winScreen.SetActive(false);
        loseScreen.SetActive(false);
    }
}

        
   
