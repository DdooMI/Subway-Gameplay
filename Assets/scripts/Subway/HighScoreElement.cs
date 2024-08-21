using System;

[Serializable]
public class HighScoreElement
{
    public string Playername;
    public int score;
    
    public HighScoreElement(string playername,int score)
    {
        Playername = playername;
        this.score = score;      
    }
}
