using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMuisc : MonoBehaviour

{

    private static BackgroundMuisc BackgroundMusic;

    void Awake()
    {
        if(BackgroundMusic == null)
        {
            BackgroundMusic = this;
            DontDestroyOnLoad(BackgroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }

}
