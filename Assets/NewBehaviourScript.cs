using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 posicao;
    // Start is called before the first frame update
    
    Vector3 m;
    void Start()
    {
        //m = new Vector3(2,2,2);
        transform.position = m;
        m.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        m.Set(0, 0, 0);

        if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.01f;
            transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.01f;
            transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.W))
        {
            m.z = 0.01f;
            transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.01f;
            transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            m.y = 0.01f;
            transform.Translate(m);
        }


        if(transform.position.x <= -9.5)
        {
            m.x = 0.1f;
        }

        if (transform.position.x >= 9.5)
        {
            m.x = -0.1f;
        }

        if (transform.position.z <= -9.5)
        {
            m.z = 0.1f;
        }

        if (transform.position.z >= 9.5)
        {
            m.z = -0.1f;

        }

        
    }

}
