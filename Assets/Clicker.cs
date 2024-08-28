using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public static int money; //���������� ��� �������� �����.
    public static int rate = 1; // ���������� ����� �� ���� ����.
    public static int energy = 1000; //����������� �������.

    public Text moneyText;
    public Text energyText;

    public void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        rate = PlayerPrefs.GetInt("rate", 1);
        energy = PlayerPrefs.GetInt("Energy", 1000);
    }
    //����� ���������
    public void FixedUpdate()
    {
        money += rate + (int)(money * 0.1);
        energy -= rate;
    }

    //������� ��� ������� �������
    public void Click()
    {
        money += rate + (int)(money * 0.1);
        PlayerPrefs.SetInt("money", money);
        energy -= rate;
        PlayerPrefs.SetInt("Energy", energy);
    }
    //����
    public void UpgradeClick()
    {
        if (money > 15)
        {
            money -= 15;
            rate += 1;

            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("rate", rate);
        }
    }
    public void Update()
    {
        moneyText.text = "$" + money;
        energyText.text = "$" + energy;

    }
    public void UpgradeEnergy()

    {
        energy -= rate;
    }
}












