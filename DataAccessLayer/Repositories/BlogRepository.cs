using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();

           
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
