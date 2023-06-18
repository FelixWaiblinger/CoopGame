using UnityEngine;
using UnityEngine.UI;

public class StatusCanvas : MonoBehaviour
{
    [SerializeField] private Image _health;
    [SerializeField] private Image _magazine;

    public void UpdateHealth(int currentHealth, int maxHealth)
    {
        _health.fillAmount = Mathf.Clamp01(currentHealth / (float)maxHealth);
    }

    public void UpdateMagazine(int currentMagazine, int maxMagazine)
    {
        _magazine.fillAmount = Mathf.Clamp01(currentMagazine / (float)maxMagazine);
    }
}
