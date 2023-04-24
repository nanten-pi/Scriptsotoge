using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonClick2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Debug.Log("‰Ÿ‚³‚ê‚½!");  // ƒƒO‚ğo—Í
            SceneManager.LoadScene("mainScenes");
        }
    }
}
