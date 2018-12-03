using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GravityPerLevel : MonoBehaviour
{
    public string LevelGravity;
    // Use this for initialization
    void Start()
    {
        // Den ändrar stringen LevelGravity till namnet på leveln du är på
        LevelGravity = (SceneManager.GetActiveScene().name);
        // Kollar vad Levelgravity har för värde
        if (LevelGravity == "Level_1")
        {
            // Om värdet är Level_1 och isåfall sätter den gravitationen till 4
            GetComponent<Rigidbody2D>().gravityScale = 4;
        }
        if (LevelGravity == "Level_2")
        {
            // Om värdet är Level_2 och isåfall sätter den gravitationen till 4
            GetComponent<Rigidbody2D>().gravityScale = 2;
        }
        if (LevelGravity == "Level_2-5")
        {
            //Om värdet är Level_2-5 och isåfall sätter den gravitationen till 1.5 och så ändrar man talet till en float
            GetComponent<Rigidbody2D>().gravityScale = 1.5f;
        }
        //om ingen av if:sen har sina kriterier uppfyllda så händer den här
        else
        {
            // Om värdet är något annat så sätter den gravitationen till 2
            GetComponent<Rigidbody2D>().gravityScale = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
