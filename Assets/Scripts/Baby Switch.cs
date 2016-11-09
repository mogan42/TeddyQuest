﻿using UnityEngine;
using System.Collections;

public class BabySwitch : MonoBehaviour
{
    public GameObject button1, itemToRemove;
    // Use this for initialization
    void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 1));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == button1)
                {
                    itemToRemove.SetActive(false);
                    button1.gameObject.layer = LayerMask.NameToLayer("Default");
                }
            }
        }
    }
}
