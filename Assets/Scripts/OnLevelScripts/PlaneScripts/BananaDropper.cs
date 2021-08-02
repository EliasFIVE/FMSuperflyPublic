using System.Collections;
using UnityEngine;

public class BananaDropper : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private float dropForce = 1;

    private Transform dropAnchor;
    private BananaPool bananaPool;

    void Awake()
    {
        dropAnchor = gameObject.transform;
        bananaPool = gameObject.GetComponent<BananaPool>();
    }
    private void Start()
    {
        ScoreTracker.Instance.ScoreChangeEvent.AddListener(HandleScoreChange);
    }

    private void HandleScoreChange(int scoreChangeValue)
    {
        if (scoreChangeValue < 0)
            DropBananasByAmount(-scoreChangeValue);
    }
    private void DropBananasByAmount(int amountOfBananasToDrop)
    {
        if (amountOfBananasToDrop <= 0)
        {
            Debug.LogWarning("Banana Dropper trying to drop zero or negative amount of bananas");
            return;
        }
        StartCoroutine(DropBananasCoroutine(amountOfBananasToDrop));
    }
    IEnumerator DropBananasCoroutine(int amountOfBananasToDrop)
    {
        for (int i = 0; i < amountOfBananasToDrop; i++)
        {
            GameObject banana = bananaPool.GetBananaByIndex(i); //assume that all banans are not Active
            ResetBananaPosition(banana);
            yield return new WaitForSeconds(0.1f);
            ActivateAndDropBanana(banana);
        }
    }
    private void ResetBananaPosition(GameObject banana)
    {
        banana.gameObject.SetActive(false);
        banana.transform.position = dropAnchor.position;
    }
    private void ActivateAndDropBanana(GameObject banana)
    {
        banana.SetActive(true);
        Vector3 forceNormal = new Vector3(Random.Range(-50, 50), 10, 1).normalized;
        Rigidbody bananaRigid = banana.GetComponent<Rigidbody>();
        bananaRigid.velocity = Vector3.zero;
        bananaRigid.AddForce(forceNormal * dropForce, ForceMode.Impulse);
    }
}
