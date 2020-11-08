using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParamBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Decease( float value )
    {
        gameObject.GetComponent<Slider>().value -= value;
        if (gameObject.GetComponent<Slider>().value < 0.0f)
        {
            gameObject.GetComponent<Slider>().value = 0.0f;
        }
    }
}
