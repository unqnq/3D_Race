using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject canvasPause;
    bool isPaused = false;

    void Awake()
    {
        canvasPause = GameObject.Find("PauseCanvas");
    }
    void Start()
    {
        canvasPause.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Time.timeScale = 0;
                isPaused = true;
            }
            else
            {
                Time.timeScale = 1;
                isPaused = false;
            }

            canvasPause.SetActive(isPaused);
        }
    }
}
