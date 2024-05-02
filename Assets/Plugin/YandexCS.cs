using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

public class YandexCS : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Show();
    [SerializeField] private bool isShow = true;
    [SerializeField] public int second;

    private void Awake()
    {
        second = Savetimer();
        Inaction60();
    }
    private void Start()
    {
        Inaction2();
    }
    private void Inaction60()
    {
        StartCoroutine(Timer());
        IEnumerator Timer() 
        {
            while (true)
            {
                Debug.Log(second);
                yield return new WaitForSeconds(1);
                second++;
                second %= 60;
                if (second == 0) isShow = true;
            }
        }
    }
    private void Inaction2()
    {
        float secondInaction = 0;
        while (ControllerGame.isPause == true && isShow == true)
        {
            Debug.Log(secondInaction);
            secondInaction += Time.deltaTime;
            secondInaction %= 4;
            if (secondInaction == 0 && isShow == true)
            {
                isShow = false;
                second = 0;
                Show();
            }
        }
    }
    private int Savetimer()
    {
        if (PlayerPrefs.HasKey("second"))
        {
            Debug.Log("Key true");
            return PlayerPrefs.GetInt("second");
        }
        else return 0;
    }
    private void OnDisable()
    {
        PlayerPrefs.SetInt("second", second);
    }
}
