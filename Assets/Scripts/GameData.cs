using UnityEngine;


public class GameData : MonoBehaviour
{
    public static GameData Instance { get; private set; }

    [SerializeField] public string Player1Character = null;
    [SerializeField] public string Player2Character = null;
    [SerializeField] public string SelectedStage = null;
    private (string Winner, string Loser) ? matchResult;

    private void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // Ensures the object persists across scene loads
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerCharacter(int playerNum, string characterName)
    {
        if (playerNum == 1)
        {
            Player1Character = characterName;
        }
        else if (playerNum == 2)
        {
            Player2Character = characterName;
        }
        else
        {
            Debug.LogError("Invalid player number!");
        }
    }

    public void SetStage(string stageName)
    {
        SelectedStage = stageName;
    }

    public void SetMatchResult(string winner, string loser)
    {
        matchResult = (winner, loser);
    }

    public void DisplayGameData()
    {
        Debug.Log($"Player 1 selected: {Player1Character}");
        Debug.Log($"Player 2 selected: {Player2Character}");
        Debug.Log($"Selected stage: {SelectedStage}");

        if (matchResult.HasValue)
        {
            Debug.Log($"Match result: {matchResult.Value.Winner} defeated {matchResult.Value.Loser}");
        }
    }
}