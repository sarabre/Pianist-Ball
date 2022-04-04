using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private static Manager instance;

    public static Manager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<Manager>();
            return instance;
        }
    }

    public audioManager audioManager;
    public levelManager levelManager;


}
