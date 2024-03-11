using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndArifOzanAKTAS.Models.ORM;
public class Product : BaseModel
{
    [MaxLength(40)]
    public string ProductName { get; set; }

    [ForeignKey("SupplierId")]
    public int? SupplierId { get; set; }
    public Supplier? Supplier { get; set; }

    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    [MaxLength(20)]
    public string? QuantityPerUnit { get; set; }
    public double? UnitPrice { get; set; }
    public Int16? UnitsInStock { get; set; }
    public Int16? UnitsOnOrder { get; set; }
    public Int16? ReorderLevel { get; set; }
    public Boolean Discontinued { get; set; }



}
