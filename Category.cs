namespace Project;

public class Category
{
    public int CategoruId { get; set; }
    public string CategoruName { get; set; }
    public Category(int id, string name)
    {
        CategoruId = id;
        CategoruName = name;
    }
    public Category()
    {
        
    }
}
