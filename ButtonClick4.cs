using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonClick4 : MonoBehaviour
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
            Debug.Log("押された!");  // ログを出力
            SceneManager.LoadScene("EndScenes");
        }
    }
}
