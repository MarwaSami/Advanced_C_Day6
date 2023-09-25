using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Category : ICategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    private event Action<ICategory> addeventcategory;
    public event Action<ICategory> addEventcategory
    {
        add
        {
            addeventcategory += value;
        }
        remove { 
            addeventcategory -= value;
        }
    }
    public void Add()
    {
        Console.WriteLine("Adding Category");
            addeventcategory(this);
    }
}

