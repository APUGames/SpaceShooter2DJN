using UnityEngine;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{
    [SerializeField]
    private PlayerHealthController playerHealthController;
    [SerializeField]
    private GameObject playerScoreText;
    [SerializeField]
    private GameObject playerWonText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        bool playerWon = GameManager.Instance.GetPlayerWon();
        int playerPoints = GameManager.Instance.GetPlayerPoints();
        int playerWinPoints = GameManager.Instance.GetPlayerWinPoints();

        playerScoreText.GetComponent<Text>().text = $"{playerPoints}/{playerWinPoints}";

        if (playerWon)
        {
            playerWonText.SetActive(true);
        }
        else
        {
            playerWonText.SetActive(false);
        }
    }
}
