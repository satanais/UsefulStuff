using System.Collections;
using UnityEngine;

public class IceMagic : MonoBehaviour
{
    [SerializeField] private GameObject[] m_snowCircle;
    [SerializeField] private float m_circleApparition;
    [SerializeField] private GameObject m_iceRod;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (GameObject p in m_snowCircle)
        {
            p.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private IEnumerator EStartCircles()
    {
        m_snowCircle[0].SetActive(true);

        yield return new WaitForSeconds(m_circleApparition);

        m_snowCircle[1].SetActive(true);
        yield return new WaitForSeconds(m_circleApparition);

        m_snowCircle[2].SetActive(true);

    }

    public void Circles()
    {
        StartCoroutine(EStartCircles());
        Debug.Log("Start circles");
    }

    public void FirstIce()
    {
        Vector3 pos = new Vector3 (m_snowCircle[0].transform.position.x, -1.0f, m_snowCircle[0].transform.position.z);
        Debug.Log("First Ice");
        object clone = Instantiate(m_iceRod, pos    );


    }

    public void SecondIce()
    {
        Debug.Log("Second Ice");


    }

    public void ThirdIce()
    {
        foreach (GameObject p in m_snowCircle)
        {
            p.SetActive(false);
        }

        Debug.Log("Third Ice");


    }
}
