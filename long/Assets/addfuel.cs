using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addfuel : MonoBehaviour
{
    public CarController carcontroller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        carcontroller.fuel = 1;
        Destroy(gameObject);
    }

}
