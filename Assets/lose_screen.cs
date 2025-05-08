using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lose_screen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject lose_panel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("HARMER"))
        {
            Time.timeScale = 0f;
            stat_text.text = game_stats_timer.get_victims();
            lose_panel.SetActive(true);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public Text stat_text;

}
