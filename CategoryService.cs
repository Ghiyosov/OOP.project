namespace Project;

public class CategoryService
{
    List<Category> _categories = new List<Category>();
    public List<Category> GetCategories()
    {
        return _categories;
    }
    public Category GetByIdCatigory(int id)
    {
        return _categories.FirstOrDefault(p=>p.CategoruId==id);
    }
    public void AddCatigory(Category category)
    {
        _categories.Add(category);
    }
    public void UdateCategory(Category category)
    {
        var a = _categories.FirstOrDefault(p=>p.CategoruId==category.CategoruId);
        a.CategoruName = category.CategoruName;
    }
      public void DeleteCategory(int id)
    {
        var a = _categories.FirstOrDefault(p=>p.CategoruId==id);
        _categories.Remove(a);
    }
}
