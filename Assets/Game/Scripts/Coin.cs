using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;

    private void OnTriggerEnter(Collider other)
    {
        Rocket rocket = other.GetComponent<Rocket>();

        if (rocket != null)
        {
            rocket.AddCoins(Random.Range(_minValue, _maxValue + 1));
            gameObject.SetActive(false);
        }
    }
}