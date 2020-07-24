using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text contador;
    public float tiempo= 60f;
    public Text fin;
    // Start is called before the first frame update
    void Start()
    {
        contador.text = "" + tiempo;
        fin.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        contador.text = "" + tiempo.ToString("0");
        if (tiempo <= 0)
        {
            contador.text = "0";
            fin.enabled = true;
        }
        Reiniciar();
    }
    void Reiniciar()
    {
        if (Input.GetKey(KeyCode.S))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
