using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimenta : MonoBehaviour
{
    Vector3 m;

    // Start is called before the first frame update
    void Start()
    {
      //m = new Vector3(2, 10, 4);
        transform.position = m;
        m.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        m.Set(0, 0, 0);

        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.1f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m.x = -0.1f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.W))
        {
            m.z = 0.1f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.1f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            m.y = 0.1f;
            transform.Translate(m);
        }

    }
}
 