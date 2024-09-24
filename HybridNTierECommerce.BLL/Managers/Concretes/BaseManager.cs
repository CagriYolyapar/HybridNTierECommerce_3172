using HybridNTierECommerce.BLL.Managers.Abstracts;
using HybridNTierECommerce.DAL.Repositories.Abstracts;
using HybridNTierECommerce.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Managers.Concretes
{

    //Onemli : Normal şartlarda bir Manager yapısı sadece Domain Entity almaz...Buradaki metotlar DTO da (Data Transfer Object) almalıdır...Siz bir Domain Entity üzerinden iş akısı islemlerini saglıklı bir şekilde yapamazsınız...


   

    

    public  class BaseManager<T> : IManager<T> where T : class, IEntity
    {
        //Bu class IRepository ile birlikte calısmak istiyor(spesifik bir repository ile degil Main Repository ile birlikte)
        protected readonly IRepository<T> _iRep;


        //T 
        //IRepository<Category>
        //IRepository<Product>
        //BaseRepository<Product>

        public BaseManager(IRepository<T> iRep) //Burada dikkat ederseniz BaseManager constructor'i bir Parametre alıyor(IRepository<T> tipinde) IOC (Inversion of Controls) paternine göre burada belirtilen tip Middleware'de görülürse bize instance'i alınabilecek bir şey gönderilir...Bizim istedigimiz IRepository<T> generic tipi algılandıgı anda BaseRepository<T> instance'i buraya gönderilecektir...Bu yüzdendir ki BaseRepository'i Abstract yapmadık...
        {
            _iRep = iRep;
        }


        void SaatEkle(T item)
        {
            item.CreatedDate = item.CreatedDate.AddHours(3);
        }

        bool ElemanKontrol(List<T> list)
        {
            if (list.Count > 10) return false;
            return true;
        }


        public string Add(T item)
        {
            //SaatEkle(DTO)

            //Mapping DTO => DomainEntity

            SaatEkle(item);
            _iRep.Add(item);

            return "Ekleme işlemi basarılıdır";



        }

        public async Task<string> AddAsync(T item)
        {
            //SaatEkle(DTO)

            //Mapping DTO => DomainEntity

            SaatEkle(item);
            await _iRep.AddAsync(item);

            return "Ekleme işlemi basarılıdır";
        }

        public string AddRange(List<T> list)
        {
            if (!ElemanKontrol(list)) return "Maksimum 10 veri ekleyebileceginiz icin işlem gerçekleştirilemedi";
            _iRep.AddRange(list);
            return "Ekleme basarılıdır";
        }

        public async Task<string> AddRangeAsync(List<T> list)
        {
            if (!ElemanKontrol(list)) return "10'dan veri ekleyemezsiniz";
            await _iRep.AddRangeAsync(list);
            return "Ekleme basarılıdır";
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            //Veritabanından cekeceksiniz

            return _iRep.Any(exp);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await _iRep.AnyAsync(exp);
        }

        public void Delete(T item)
        {
            _iRep.Delete(item);

        }

        public string DeleteRange(List<T> list)
        {
            //if (!ElemanKontrol(list)) return "10'dan fazla veri girişi yapamazsınız";
            _iRep.DeleteRange(list);
            return "Silme basarılı";



        }

        public string Destroy(T item)
        {
            if (item.Status == ENTITIES.Enums.DataStatus.Deleted)
            {
                _iRep.Destroy(item);
                return "Silme işlemi basarılı";
            }
            return "Veriyi silebilmeniz icin önce verinin pasifleştirilmesi lazım";
        }

        //Todo: DestroyRange'de liste icerisindeki pasif olmayan elemana kadar destroy işlemi yapılsın. Ama pasif olan elemana denk gelindigi anda kullanıcıya densin ki su veriler silindi ama bunlar dısındakiler pasiflik ile ilgili bir sorun oldugu icin onlara dokunulmadı...

        public async Task<T> FindAsync(int id)
        {
            return await _iRep.FindAsync(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _iRep.FirstOrDefault(exp);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await _iRep.FirstOrDefaultAsync(exp);
        }

        public List<T> GetActives()
        {
            return _iRep.GetActives();
        }

     

        public List<T> GetAll()
        {
            return _iRep.GetAll();
        }

        public List<T> GetFirstDatas(int count)
        {
            return _iRep.GetFirstDatas(count);
        }

        public List<T> GetLastDatas(int count)
        {
           return _iRep.GetLastDatas(count);
        }

        public List<T> GetModifieds()
        {
            return _iRep.GetModifieds();
        }

        public List<T> GetPassives()
        {
            return _iRep.GetPassives();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _iRep.Select(exp);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _iRep.Select(exp);
        }

        public async Task UpdateAsync(T item)
        {
           await _iRep.UpdateAsync(item);
        }

        public async Task UpdateRangeAsync(List<T> list)
        {
            await _iRep.UpdateRangeAsync(list);
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _iRep.Where(exp);
        }
    }
}
