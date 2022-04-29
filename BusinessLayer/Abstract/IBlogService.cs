                  using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IBlogService:IGenericService<Blog>
    {
      

        List<Blog> GetBlogListWithCategory();  // IGenericService den ziyade ektra sadece blog için yazılan metot

        List<Blog> GetBlogListByWriter(int id);// IGenericService den ziyade ektra sadece blog için yazılan metot
    }
}
