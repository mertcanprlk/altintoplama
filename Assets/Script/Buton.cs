﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buton : MonoBehaviour
{
    public void DigerSahne()
    {
        SceneManager.LoadScene("sahne");
    }
    public void YenidenBasla()
    {
        SceneManager.LoadScene("sahne");
    }
}
