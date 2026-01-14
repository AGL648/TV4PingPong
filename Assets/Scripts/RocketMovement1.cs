using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement1 : MonoBehaviour
{
    //Velocidad de la raqueta
    public float racketSpeed = 25;
    //El eje que quiero usar
    public string axis = "Horizontal";
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
        //Accedemos al componente del RigidBody del objeto donde est� metido el script y le aplicamos una velocidad en X
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(v, 0) * racketSpeed;//Multiplicamos por la velocidad de movimiento => 1*25 � -1*25
        
    }
}
