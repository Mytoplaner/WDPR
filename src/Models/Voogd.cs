using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Voogd : Account
{
    [ForeignKey("ApplicatieGebruiker")]
    public virtual ApplicatieGebruiker User {get; set;}     //ef core link naar applicatiegebruiker class van identiy
    public Client Client {get; set;}
    
    public int? checkFrequentie()
    {
        return null;
        // Moet nog aanvulling krijgen
    }
}