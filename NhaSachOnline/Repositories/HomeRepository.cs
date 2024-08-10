using NhaSachOnline.Data;
using NhaSachOnline.Models;

namespace NhaSachOnline.Repositories
{
  public class HomeRepository
  {
    private readonly ApplicationDbContext _dbContext;

    public HomeRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    //public async Task<IEnumerable<Book>> LayThongTinSachTuDatabase(string keySearch = "", int theLoaiId = 0)
    //{
    //  // chuyển đổi chuỗi sang dạng chữ thường
    //  keySearch = keySearch.ToLower();

    //  IEnumerable<Book> books = await ().ToListAsync();
    //  return books;
    //}
  }
}
