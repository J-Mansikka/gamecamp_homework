using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    int deathcounter;

    // Start is called before the first frame update
    void Start()
    {
        deathcounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f,0f,-0.6f);
        deathcounter++;

        if(deathcounter >= 3000) {
            Destroy(gameObject);
        }
    }
}
