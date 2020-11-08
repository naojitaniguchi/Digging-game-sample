using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public float waitTime = 1.0f ;
    public GameObject floorObject;
    bool fall = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if ( floorObject == null)
        {
            if ( fall == false)
            {
                StartCoroutine("FallStart");
            }
        }
        // Debug.Log(floorObject);
    }

    IEnumerator FallStart()
    {
        fall = true;
        yield return new WaitForSeconds(waitTime);
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
    }
}
