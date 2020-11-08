using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerExp : MonoBehaviour
{
    public GameObject expText;
    public bool initExp = false;
    int expValue;
    // Start is called before the first frame update
    void Start()
    {
        if (initExp)
        {
            expValue = 0;
            PlayerPrefs.SetInt("Exp", expValue);
            expText.GetComponent<Text>().text = expValue.ToString();
        }
        else
        {
            expValue = PlayerPrefs.GetInt("Exp");
            expText.GetComponent<Text>().text = expValue.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            expValue = PlayerPrefs.GetInt("Exp");
            expValue++;
            expText.GetComponent<Text>().text = expValue.ToString();
            PlayerPrefs.SetInt("Exp", expValue);



            PlayerPrefs.SetInt("Flag1", 0);
            PlayerPrefs.SetInt("Flag2", 1);
            PlayerPrefs.SetString("PlayerName", "あいうえお");
        }
    }
}
