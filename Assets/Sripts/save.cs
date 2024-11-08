using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    // ����� ��� ���������� ������
    private const string ScoreKey = "PlayerScore";
    private const string LevelKey = "PlayerLevel";

    // ����� ��� ���������� ������
    public void SaveGameData(int score, int level)
    {
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.SetInt(LevelKey, level);
        PlayerPrefs.Save(); // ��������� ������ �� ����
    }

    // ����� ��� �������� ������
    public void LoadGameData(out int score, out int level)
    {
        score = PlayerPrefs.GetInt(ScoreKey, 0); // 0 � �������� �� ���������
        level = PlayerPrefs.GetInt(LevelKey, 1); // 1 � �������� �� ���������
    }

    // ����� ��� �������� ����������� ������
    public void DeleteGameData()
    {
        PlayerPrefs.DeleteKey(ScoreKey);
        PlayerPrefs.DeleteKey(LevelKey);
        PlayerPrefs.Save(); // ��������� ��������� �� ����
    }
}
