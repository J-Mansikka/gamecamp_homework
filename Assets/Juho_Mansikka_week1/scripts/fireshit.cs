using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireshit : MonoBehaviour
{
    float counter1;

    float counter2;
    float increment;

    public GameObject bullet;
    public GameObject fx;
    // Start is called before the first frame update
    void Start()
    {
        counter1 = Random.Range(2f,5f);
        counter2 = Random.Range(2f,5f);
        increment = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        counter1 -= increment;
        counter2 -= increment;

        if(counter1 < 0f) {
            fire();
            counter1 = Random.Range(2f,5f);
        }

        if(counter2 < 0f) {
            fire();
            counter2 = Random.Range(2f,5f);
        }
    }

    private void fire(){
        Vector3 spot = new Vector3(Random.Range(-30f,30f),Random.Range(-15f,15f),300f);
        Instantiate(fx,spot,Quaternion.identity);
        Instantiate(bullet,spot,Quaternion.identity);
    }
}
