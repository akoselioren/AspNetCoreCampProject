﻿using BusinessLayer.Abstract;
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
		public List<Blog> GetLast3Blog()
		{
			return _blogdal.GetListAll().Take(3).ToList();
		}

        public Blog GetById(int id)
		{
			throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void TDelete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
