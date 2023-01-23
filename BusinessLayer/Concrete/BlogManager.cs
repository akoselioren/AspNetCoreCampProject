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
		IBlogDal _blogdal;

		public BlogManager(IBlogDal blogdal)
		{
			_blogdal = blogdal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAllCategories()
		{
			return _blogdal.GetListAll();
		}

        public List<Blog> GetBlogListWithCategory()
        {
           return _blogdal.GetListWithCategory();
        }
		public List<Blog> GetListWithCategoryByWriterBM (int id)
		{
			return _blogdal.GetListWithCategoryByWriter(id);
		}
		public List<Blog> GetLast3Blog()
		{
			return _blogdal.GetListAll().Take(3).ToList();
		}

        public Blog TGetById(int id)
		{
			return _blogdal.GetById(id);
		}

		public List<Blog> GetBlogByID(int id)
		{
			return _blogdal.GetListAll(x => x.BlogID == id);

		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogdal.GetListAll(x => x.WriterID == id);
		}

        public void TAdd(Blog t)
        {
            _blogdal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogdal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
           _blogdal.Update(t);
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetListAll();
        }
    }
}
