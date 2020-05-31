using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship_controls : MonoBehaviour
{

    //float rot;
    float xPos;
    float yPos;

    public Collider missile;

    bool alive;

    float explosionTimer;

    public GameObject fx;

    int endGame;

    int score;

    public Text gameTeksti;

    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        xPos = 0f;
        yPos = 0f;
        moveShip();
        explosionTimer = 10f;
        endGame = 10;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(alive) {
            score++;
        }
        if (Input.GetAxis("Horizontal") != 0f && alive) {
            xPos += Input.GetAxis("Horizontal") * 0.1f;
            if(xPos > 30f) {
                xPos = 30f;
            } else if (xPos < -30f) {
                xPos = -30f;
            }
        }

        if (Input.GetAxis("Vertical") != 0f && alive) {
            yPos += Input.GetAxis("Vertical") * 0.1f;
            if(yPos > 15f) {
                yPos = 15f;
            } else if (yPos < -15f) {
                yPos = -15f;
            }
        }

        if(!alive) {
            yPos -= 0.05f;
            explosionTimer -= 0.1f;
            if (explosionTimer < 0f) {
                explosionTimer = 10f;
                Instantiate(fx,new Vector3(xPos,yPos,0f),Quaternion.identity);
                endGame--;
                if (endGame == 0) {
                    Application.Quit();
                }
            }
        }

        moveShip();
    }

    private void moveShip() {
        transform.position = new Vector3(xPos,yPos,0f);
    }

    void OnCollisionEnter(Collision collision){
        alive = false;
        gameTeksti.text = "GAME OVER, TOM!\nSCORE: "+ (score / 100);
        print("Ffffffffffffffffffffffff");
    
    }
}
