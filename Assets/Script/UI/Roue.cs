using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Roue : MonoBehaviour
{
    public List<Button> Buttons = new List<Button>();
    private int index;
    private ColorBlock _colorBlock;

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

        if (Input.GetKeyDown("e"))
        {
            index++;
            transform.Rotate(Vector3.forward, 90);
            if (index >= Buttons.Count)
            {
                index = 0;
            }
            Debug.Log(index);
        }

        if (Input.GetKeyDown("r"))
        {
            index--;
            transform.Rotate(Vector3.forward, -90);
            if (index <= -1)
            {
                index = Buttons.Count - 1;
            }
            Debug.Log(index);
        }

        EventSystem.current.SetSelectedGameObject(Buttons[index].gameObject);

        if (Input.GetButtonDown("Submit"))
        {
            if (index == 0)
           {
                SkyState.Sun();
            } 
            if (index == 1) {
                SkyState.Snow();
            } 
            if (index == 3) {
                SkyState.Rain();
            } 
            if (index == 2) {
                SkyState.Wind();
            }
        }
    }
}

