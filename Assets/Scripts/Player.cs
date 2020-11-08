using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f ;
    public GameObject HPBar;
    public GameObject ItemManager;
    GameObject blockObject = null;
    GameObject floorObject = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * -1.0f;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (blockObject != null)
            {
                if ( blockObject.transform.position.x < gameObject.transform.position.x)
                {
                    HPBar.GetComponent<ParamBar>().Decease(1.0f);
                    blockObject.GetComponent<Block>().hitCount--;
                    if (blockObject.GetComponent<Block>().hitCount <= 0)
                    {
                        Destroy(blockObject);
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (blockObject != null)
            {
                if (blockObject.transform.position.x > gameObject.transform.position.x)
                {
                    HPBar.GetComponent<ParamBar>().Decease(1.0f);
                    blockObject.GetComponent<Block>().hitCount--;
                    if (blockObject.GetComponent<Block>().hitCount <= 0)
                    {
                        Destroy(blockObject);
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (floorObject != null)
            {
                if (floorObject.transform.position.y < gameObject.transform.position.y)
                {
                    Debug.Log(floorObject);
                    Debug.Log(floorObject.GetComponent<Block>());

                    HPBar.GetComponent<ParamBar>().Decease(1.0f);

                    floorObject.GetComponent<Block>().hitCount--;
                    if (floorObject.GetComponent<Block>().hitCount <= 0)
                    {
                        Destroy(floorObject);
                    }
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Item")
        {
            Debug.Log("Get Item!!!!!");
            ItemManager.GetComponent<ItemManager>().addKey();
            Destroy(col.gameObject);

        }
        else
        {
            if (col.gameObject.transform.position.y < gameObject.transform.position.y - 0.1)
            {
                floorObject = col.gameObject;
            }
            else
            {
                blockObject = col.gameObject;
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        blockObject = null;
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.transform.position.y < gameObject.transform.position.y - 0.1)
        {
            floorObject = col.gameObject;
        }
        
        //Debug.Log(floorObject.name);
    }
}
