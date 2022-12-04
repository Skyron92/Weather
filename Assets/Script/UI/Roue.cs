using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roue : MonoBehaviour
{
    public List<Button> Buttons = new List<Button>();
    private int index;

    void Start()
    {
        foreach (var button in GetComponentsInChildren<Button>())
        {
            Buttons.Add(button);
        }
    }

    private void Update()
    {
        ChangeMeteo();
    }

    void ChangeMeteo()
    {

        if (Input.GetKeyDown("r"))
        {
            index++;
            transform.Rotate(Vector3.forward, 90);
            if (index >= Buttons.Count)
            {
                index = 0;
            }
            Debug.Log(index);
        }

        if (Input.GetKeyDown("e"))
        {
            index--;
            transform.Rotate(Vector3.forward, -90);
            if (index <= -1)
            {
                index = Buttons.Count - 1;
            }
            Debug.Log(index);
        }
    }
}

