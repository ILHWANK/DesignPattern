using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    public void SceneTrans1() {
        SceneManager.LoadScene("SingletonePattern1");
    }

    public void SceneTrans2()
    {
        SceneManager.LoadScene("SingletonePattern2");
    }
   
}
