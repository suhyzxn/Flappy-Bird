using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Die()
    {
        Invoke("GameOver", 2f);
    }

    void GameOver()
    {
        Time.timeScale = 0;
    }
}
