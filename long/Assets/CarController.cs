using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
   
    [HideInInspector]
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 5;
    public float carTorque = 10;
    private float movement;
    public UnityEngine.UI.Image image;
    public float maxSpeed;

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
    
    public void buttomA()
    {
        movement = -1f;
    }

    public void buttomD()
    {
        movement = 1f;
        
    }

    public void buttonE()
    {
        movement = 0;
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount = fuel;
    }

    private void FixedUpdate()
    {

        if(fuel > 0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRigidbody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
        }
        else
        {
            SceneManager.LoadScene(2);
        }

        

        fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }
}