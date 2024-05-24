﻿using BlogForest.BusinessLayer.Abstract;
using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DtoLayer.CategoryDtos;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Category TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ResultCategoryWithCountDto> TGetCategoryWithCount()
        {
            return _categoryDal.GetCategoryWithCount();
        }

        public List<Category> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
