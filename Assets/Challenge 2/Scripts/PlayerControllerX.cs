using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private const float reuseValue = 0;
    private float coolToReuse = 0;

    // Update is called once per frame
    void Update()
    {
        if( coolToReuse > reuseValue)
        { coolToReuse -= Time.deltaTime;
        }


        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && coolToReuse <= reuseValue )
        {
            coolToReuse = 0.5f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
