using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themxang : MonoBehaviour
{
    public CarController car;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        car.fuel = 1;
        Destroy(gameObject);
    }
}
