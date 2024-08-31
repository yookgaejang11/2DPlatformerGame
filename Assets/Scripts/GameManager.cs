using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameClearset;
    public GameObject player;
    public GameObject gameOverSet;
    public GameObject First_Trap;
    public GameObject Second_Trap;
    public GameObject Third_Trap;
    public GameObject Fifth_Trap;
    public void GameOver()
    {
        player.SetActive(false);
        gameOverSet.SetActive(true);
    }
    public void gameClear()
    {
        gameClearset.SetActive(true);
        Time.timeScale = 0f;
    }
    public void GameRetry()
    {
        SceneManager.LoadScene(0);//0 ¾È¿¡  ¾À ÀÌ¸§ ³Ö¾îµµµÊ
        Time.timeScale = 0f;
    }
    public void Trap1()
    {
        First_Trap.SetActive(true);
    }
    public void Trap2()
    {
        Second_Trap.SetActive(true);
    }
    public void Trap3()
    {
        Third_Trap.SetActive(true);
    }
    public void Trap5()
    {
        Fifth_Trap.SetActive(true);
    }
}
