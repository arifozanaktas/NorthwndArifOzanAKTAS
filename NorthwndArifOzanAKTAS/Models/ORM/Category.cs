using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndArifOzanAKTAS.Models.ORM;
public class Category : BaseModel
{
    [MaxLength(15)]
    public string CategoryName { get; set; }
    public string? Description { get; set; }
    public Byte[]? Picture { get; set; }

}
