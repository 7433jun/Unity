using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScene : MonoBehaviour
{
    [SerializeField] ButtonManager buttonManager;
    public void NextScene(int select)
    {
        foreach (var e in buttonManager.monster)
        {
            if (e.activeSelf == true)
            {
                DontDestroyOnLoad(e);
            }
        }

        SceneManager.LoadScene(select);
        
    }
}
