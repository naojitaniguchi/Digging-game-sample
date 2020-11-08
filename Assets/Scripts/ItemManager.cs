using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] keys;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addKey()
    {
        for ( int i = 0; i < keys.Length; i ++)
        {
            if (!keys[i].activeSelf)
            {
                keys[i].SetActive(true);
                break;
            }
        }
    }
}
