
 public  abstract class Examen
{ 
    private int date_debut ;

    public Examen(int date_debut) 
    {
        this.date_debut = date_debut;
    
    
    }

    public double mesure_duree( int date_fin)
    {

        return  date_debut + date_fin;

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





