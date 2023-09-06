using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();
    private GameObject lastObject;
    private void Start()
    {
        UpdateLastBlockObject();
    }

    public void AddBlockStack(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y +2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastObject.transform.position.x, lastObject.transform.position.y -2f, lastObject.transform.position.z); 
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);
        UpdateLastBlockObject();
    }
    public void MinusBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlockObject();
    }
    private void UpdateLastBlockObject()
    {
        lastObject = blockList[blockList.Count - 1];
    }
}

