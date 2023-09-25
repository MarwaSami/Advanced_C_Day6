using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public delegate void add_category(ICategory category);
    public  interface ICategory
    {
     public int Id { get; set; }
     public string Name { get; set; }
    public event Action<ICategory> addEventcategory;
    public void Add();
     
    }

