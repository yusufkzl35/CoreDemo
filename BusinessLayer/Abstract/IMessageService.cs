using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IMessageService : IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);//yazara göre mesaj getir//bu fonksiyon statictir ve sadece message için tanımlıdır.Başka Managerlar bu fonksiyonu görmez.
        

    }
}
