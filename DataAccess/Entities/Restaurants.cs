using System.ComponentModel.DataAnnotations; // for key
using System.ComponentModel.DataAnnotations.Schema; // for column data annotations specfifically

namespace DataAccess.Entities;

public class Restraurants {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // by convetion Id or <EntityName>Id these annotations will be added, but explicit is recommended
    public int Id {get; set;}

    [Column(TypeName = "varchar(200)")]
    public string Name { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string location { get; set; }

    [Column(TypeName =  "varchar(200)")]
    public string rating {get; set;}
}