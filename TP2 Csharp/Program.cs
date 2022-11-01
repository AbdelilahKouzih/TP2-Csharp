
 public class Examen
{ 
    private string date_debut ;

    public Examen(string date_debut) 
    {
        this.date_debut = date_debut;
    
    
    }
}

public class Question : Examen
{
    private string type;


    public void repondre()
    {
        
    }


}

public class Reponse
{
    private string degre_certitude;


}

