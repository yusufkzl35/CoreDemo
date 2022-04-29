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
    public class CommentManager : ICommentService //consructer için CommnetManager üzerinde ctrl + . ya bas
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetCommentWithBlog()// commentservice de başlığın ismi oluşturuldu.
        {
         return   _commentDal.GetListWithBlog(); //Data acceste abstrac klasöründe metod tanımlandı ve Ef klasöründe  içi dolduruldu.
        }

        public List<Comment> GetList(int id)//id lerin hepsini getirsin diye blogıd ile eşitledim.
        {
          return  _commentDal.GetListAll(x=>x.BlogId==id);
        }

     
    }
}
