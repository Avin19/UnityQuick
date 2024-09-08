[System.Serializable]

public class PlayerData
{
    public int level;
    public int health;
}

string json = JsonUtility.ToJson(playerData);

PlayerData loadedData = JsonUtility.FromJson<PlayerData>(json);
