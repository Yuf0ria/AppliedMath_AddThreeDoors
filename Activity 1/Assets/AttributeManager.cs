using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributeManager : MonoBehaviour
{
    public Text attributeDisplay;
    static public int MAGIC = 16;
    static public int INTELLIGENCE = 8;
    static public int CHARISMA = 4;
    int attributes = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
        attributeDisplay.transform.position = screenPoint + new Vector3(0,-50,0);
        attributeDisplay.text = Convert.ToString(attributes, 2).PadLeft(8, '0');
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Magic")
        {
            attributes |= MAGIC;
        }
        else if (other.gameObject.tag == "Intelligence")
        {
            attributes |= INTELLIGENCE;
        }
        else if (other.gameObject.tag == "Charisma")
        {
            attributes |= CHARISMA;
        }
        else if (other.gameObject.tag == "Invisible")
        {
            if (MAGIC > 0 && INTELLIGENCE > 0)
            {
                attributes |= MAGIC = 0;
                attributes |= INTELLIGENCE = 0;
            }
            else
            {
                attributes = 0;
            }
        }
    }

}
