using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // när du trycker ner Space så tar den namnet på leveln du är på och laddar in den igen så att du startar om
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}
