
 public  abstract class Examen
{ 
    private int date_debut ;

    public Examen(int date_debut) 
    {
        this.date_debut = date_debut;
    
    
    }

    public double getmesure_duree( int date_fin)
    {

        return date_debut + date_fin;

    }


}



public class Question 
{
    private string type;


    public Question() { }
    public bool repondre( bool reponder) 
    {
        return reponder;
        
    }


}




public class Reponse
{
    private int degre_certitude;

    public Reponse() { }
    public  int get_degre_certitude()
    {
        return degre_certitude;
    }
}



public class Proposition
{
    private int nbr_proposition;
    public Proposition() { }

     public int getnbr_proposition()
    {
        return nbr_proposition;
    }
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

    public bool reussir( bool reuss)
    {
        return reuss;
    }
     
}





