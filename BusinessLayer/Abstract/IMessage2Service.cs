using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IMessage2Service : IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int id);//yazara göre mesaj getir//bu fonksiyon statictir ve sadece message için tanımlıdır.Başka Managerlar bu fonksiyonu görmez.
        List<Message2> GetSendBoxWithMessageByWriter(int id);
    }
}
