using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class win_screen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject win_panel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EXIT"))
        {
            Debug.Log("ESCAPED");
            Time.timeScale = 0f;
            stat_text.text = game_stats_timer.get_victims();
            win_panel.SetActive(true);
        }
    }

    public void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public Text stat_text;
}
