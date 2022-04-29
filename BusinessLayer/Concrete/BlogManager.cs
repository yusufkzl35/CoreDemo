using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {

        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithCategory() //categori ile birlikte Blogları getirir
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetListWithCategoryByWriterBlogManager(int id)// blogbywriter sayfası içinde kategorilerin ismini listede yazılmasını sağlayan fonksiyon
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }


        public Blog TGetById(int id)
        {
            return _blogDal.GetById(id);

        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();//blogları alan kısım
        }

        public List<Blog> GetLast3Blog() //son 3 blog gelir
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }


        public List<Blog> GetBlogListByWriter(int id)//yazara göre işlem yapılacak
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            
            _blogDal.Update(t);
        }
    }
}
