using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement2 : MonoBehaviour
{
    //Velocidad de la raqueta
    public float racketSpeed = 25;
    //El eje que quiero usar
    public string axis = "Vertical";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Obtenemos el valor del eje asignado
        float v = Input.GetAxis(axis);
        Debug.Log(v);
        //Accedemos al componente del RigidBody del objeto donde est� metido el script y le aplicamos una velocidad en Y
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, v) * racketSpeed;//Multiplicamos por la velocidad de movimiento => 1*25 � -1*25
    }
}
