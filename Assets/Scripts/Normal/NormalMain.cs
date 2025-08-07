using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.M)){
            //ÏÔÊ¾
            Debug.Log("µã»÷M");
            MainPanel.Show();
        }
        else if (Input.GetKeyDown(KeyCode.N)) {
            //Òþ²Ø
            Debug.Log("µã»÷NNNNN");
        MainPanel.Hide();
        }
    }
}
