using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManagerV : MonoBehaviour
{
    //Referencias a los objetos que queremos que se activen o desactiven
    public GameObject Ball;
    public GameObject RacketLeft;
    public GameObject RacketRight;
    public TextMeshProUGUI LeftScore;
    public TextMeshProUGUI RightScore;
    public TextMeshProUGUI BottomScore;
    public TextMeshProUGUI UpScore;
    public TextMeshProUGUI Title;
    public Button startButton;
    public GameObject RacketBottom;
    public GameObject RacketUp;

    
    //Referencia para guardar la direcci�n de la pelota
    Vector2 direction;

    //Creamos un Singleton
    public static GameManagerV sharedInstance;

    private void Awake()
    {
        //Si la instancia est� vac�a
        if (sharedInstance == null)
            //Rellenal� con todo el c�digo que est� dentro de este Script
            sharedInstance = this;
    }

    /*private int Player1Score;
    private int Player2Score;
    private int Player3Score;
    private int Player4Score;

    private void ResetPosition()
    {
        Ball.GetComponent<Ball>().Reset();
    }

    public void Player1Scored()
    {
        Player1Score++;
        LeftScore.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        RightScore.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    public void Player3Scored()
    {
        Player3Score++;
        BottomScore.GetComponent<TextMeshProUGUI>().text = Player3Score.ToString();
        ResetPosition();
    }

    public void Player4Scored()
    {
        Player4Score++;
        UpScore.GetComponent<TextMeshProUGUI>().text = Player4Score.ToString();
        ResetPosition();
    }*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     //M�todo para empezar juego
    public void StartGame()
    {
        //Al inicio del juego activamos y desactivamos el los juegos
        Title.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        RacketLeft.gameObject.SetActive(true);
        RacketRight.gameObject.SetActive(true);
        Ball.gameObject.SetActive(true);
        LeftScore.gameObject.SetActive(true);
        RightScore.gameObject.SetActive(true);
        RacketUp.gameObject.SetActive(true);
        RacketBottom.gameObject.SetActive(true);
        BottomScore.gameObject.SetActive(true);
        UpScore.gameObject.SetActive(true);
    }

    public void GoalScored()
    {
        //Ponemos la pelota al marcar un gol en la posici�n de origen
        Ball.transform.position = Vector2.zero; //Vector2.zero; <-> new Vector2(0,0);

        //Aqu� guardamos la velocidad en X que llevaba la pelota e invertimos su signo
        direction = new Vector2(-Ball.GetComponent<Rigidbody2D>().linearVelocity.x, 0);

        //Paramos la pelota
        Ball.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;

        //Usando Invoke esperamos X segundos antes de llamar a un m�todo
        Invoke("LaunchBall", 2.0f); //Le decimos el m�todo que quiero invocar y el tiempo que tiene que pasar en segundos para que eso suceda
    }

    //M�todo para hacer que la bola se lance
    void LaunchBall()
    {
        //Aplicamos esa nueva direcci�n en la bola
        Ball.GetComponent<Rigidbody2D>().linearVelocity = direction;
    }
}
