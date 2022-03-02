using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    enum AgeRange { 
        Age0to5,
        Age6to12,
        Age13to18,
        Age19to99
    }

    class Category
    {
        public string Name { get; set; }
        public AgeRange Age { get; set; }
        public long Id { get; set; }

        public Category(string name, AgeRange age, long id)
        {
            Name = name;
            Age = age;
            Id = id;

           
        }

        public Category(string name, AgeRange age)
        {
            Name = name;
            Age = age;
            Id = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            AddToDataSet(this);

        }

        public static void AddToDataSet(Category category) {

            DataSetHelper dataSetHelper = DataSetHelper.GetInstance();

            DataRow dataRow = dataSetHelper.TableCategories.NewRow();
            dataRow[DataSetHelper.COLUMN_CATEGORIES_NAME] = category.Name;
            dataRow[DataSetHelper.COLUMN_CATEGORIES_AGE] = category.Age;
            dataRow[DataSetHelper.COLUMN_CATEGORIES_ID] = category.Id;

            dataSetHelper.TableCategories.Rows.Add(dataRow);
            dataSetHelper.save();
        }

        public static void removeIndex(int index)
        {
            DataSetHelper dataSetHelper = DataSetHelper.GetInstance();
            dataSetHelper.TableCategories.Rows.RemoveAt(index);
            dataSetHelper.save();
        }
    }
}
