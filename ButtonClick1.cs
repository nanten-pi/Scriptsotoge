using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
     
    public class ButtonClick1 : MonoBehaviour {
     
        // ボタンが押された場合、今回呼び出される関数
        public void OnClick()
        {
            Debug.Log("押された!");  // ログを出力
            SceneManager.LoadScene("Scenes2");
        }
        void Update()
        {
            if (Input.GetKey(KeyCode.Return))
            {
                Debug.Log("押された!");  // ログを出力
                SceneManager.LoadScene("Scenes2");
            }
        }
    }
