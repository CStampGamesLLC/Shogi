using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    #region singleton

    //ensure that there is only one of these in the scene

    private static GameManager instance;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    #endregion


}
