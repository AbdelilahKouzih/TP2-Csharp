
 public  abstract class Examen
{ 
    private string date_debut ;

    public Examen(string date_debut) 
    {
        this.date_debut = date_debut;
    
    
    }


    

}

public class Question 
{
    private string type;


    public Question() { }
    public void repondre()
    {
        
    }


}

public class Reponse
{
    private string degre_certitude;

    public Reponse() { }
}

public class Proposition
{
    public Proposition() { }
}


public class Etudiant
{
    private string Nom;
    private string Prenom;

    public Etudiant(string Nom, string Prenom)
    {
        this.Nom = Nom;
        this.Prenom = Prenom;
    }

}





