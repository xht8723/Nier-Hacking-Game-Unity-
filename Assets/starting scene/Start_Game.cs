using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour {
    Button btn;
	// Use this for initialization
	void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(onClick);
	}

    void onClick() {
        SceneManager.LoadScene("NieR Hacking game");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
