using System;

public class Word
{
    private string _wordContent;
    private bool _status = true;

    public void SetStatus(bool status){
        _status = status;
    }

    public bool GetStatus(){
        return _status;
    }

    public void SetWordContent(string word){
        _wordContent = word;
    }

    public string GetWordContent(){
        return _wordContent;
    }

    public string GetContent(){
        string hidden = "";
        if(_status == true)
        {
            for (int i = 0; i < _wordContent.Length - 1; i++)
            {   
                hidden = string.Concat(hidden,"_");
            }
        return hidden;
        }
        return _wordContent;
    }
}