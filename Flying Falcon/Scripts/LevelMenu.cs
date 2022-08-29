using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    private string level;
    public int levelIndex = 0;

    public void openLevel()
    {
        level = selectedLevel();
        SceneManager.LoadScene(level); 
    }

    public string selectedLevel()
    {
        if (levelIndex == 0)
            level = "Level 1";
        else if (levelIndex == 1)
            level = "Level 2";
        else if (levelIndex == 2)
            level = "Level 3";
        else if (levelIndex == 3)
            level = "Level 4";
        else if (levelIndex == 4)
            level = "Level 5";
        else if (levelIndex == 5)
            level = "Level 6";
        else if (levelIndex == 6)
            level = "Level 7";
        else if (levelIndex == 7)
            level = "Level 8";
        else if (levelIndex == 8)
            level = "Level 9";
        else if (levelIndex == 9)
            level = "Level 10";
        else if (levelIndex == 10)
            level = "Main Menu";

        return level;
    }
}
