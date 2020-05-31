using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_fx : MonoBehaviour
{

    float size = 1f;
    float modifier = 0.3f;
    bool changeDirection;

    Vector3 sizeVec;
    // Start is called before the first frame update
    void Start()
    {
        changeDirection = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(size < 1f) {
            goBoom();
        } else if(size > 20f && changeDirection) {
            modifier *= -1f;
            changeDirection = false;
        } else {
            size += modifier;
            transform.localScale = new Vector3(size,size,size);
        }
    }

    private void goBoom() {
        Destroy(gameObject);
    }

}
