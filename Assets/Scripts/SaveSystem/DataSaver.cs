using UnityEngine;
using UnityEngine.SceneManagement;

public static class DataSaver
{
    public static void Save(Player player)
    {
        PlayerPrefs.SetFloat("Health", player.health);
        PlayerPrefs.SetInt("ScrapMetal", player.scrapMetal);
        PlayerPrefs.SetInt("Bullet", player.bullet);
        PlayerPrefs.SetFloat("PlayerX", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", player.transform.position.y);
        PlayerPrefs.SetString("MapName", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetInt("Cutscene", player.cutscene);
    }

    public static Player Load(Player player)
    {
        player.health = PlayerPrefs.GetFloat("Health",250);
        player.scrapMetal = PlayerPrefs.GetInt("ScrapMetal");
        player.bullet = PlayerPrefs.GetInt("Bullet",2);
        player.transform.position = new Vector2(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"));
        player.sceneName = PlayerPrefs.GetString("MapName");
        return player;
    }
    public static Player Load2(Player player)
    {
        player.health = PlayerPrefs.GetFloat("Health",2550);
        player.scrapMetal = PlayerPrefs.GetInt("ScrapMetal");
        player.bullet = PlayerPrefs.GetInt("Bullet",2);
        player.sceneName = PlayerPrefs.GetString("MapName");
        return player;
    }
}     