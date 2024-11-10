using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    //  лючи дл€ сохранени€ данных
    private const string ScoreKey = "PlayerScore";
    private const string LevelKey = "PlayerLevel";

    // ћетод дл€ сохранени€ данных
    public void SaveGameData(int score, int level)
    {
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.SetInt(LevelKey, level);
        PlayerPrefs.Save(); // —охран€ем данные на диск
    }

    // ћетод дл€ загрузки данных
    public void LoadGameData(out int score, out int level)
    {
        score = PlayerPrefs.GetInt(ScoreKey, 0); // 0 Ч значение по умолчанию
        level = PlayerPrefs.GetInt(LevelKey, 1); // 1 Ч значение по умолчанию
    }

    // ћетод дл€ удалени€ сохраненных данных
    public void DeleteGameData()
    {
        PlayerPrefs.DeleteKey(ScoreKey);
        PlayerPrefs.DeleteKey(LevelKey);
        PlayerPrefs.Save(); // —охран€ем изменени€ на диск
    }
}
