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

        public Category(string name, AgeRange age)
        {
            Name = name;
            Age = age;
            Id = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public Category(string name, AgeRange age, long id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public static void add(string name, AgeRange age) {

            DataSetHelper dataSetHelper = DataSetHelper.GetInstance();

            DataRow dataRow = dataSetHelper.TableCategories.NewRow();
            dataRow[DataSetHelper.COLUMN_CATEGORIES_NAME] = name;
            dataRow[DataSetHelper.COLUMN_CATEGORIES_AGE] = age;
            dataRow[DataSetHelper.COLUMN_CATEGORIES_ID] = DateTimeOffset.Now.ToUnixTimeMilliseconds(); 

            dataSetHelper.TableCategories.Rows.Add(dataRow);
            dataSetHelper.save();
        }

        public static Category get(int index) {
            DataSetHelper dataSetHelper = DataSetHelper.GetInstance();
            string name = (string)dataSetHelper.TableCategories.Rows[index][0];
            string ageStr = (string)dataSetHelper.TableCategories.Rows[index][1];
            AgeRange age = (AgeRange) Enum.Parse(typeof(AgeRange), ageStr);
            long id = long.Parse((string)dataSetHelper.TableCategories.Rows[index][2]);
            return new Category(name, age, id);
        }

        public static void add(Category category)
        {

            DataSetHelper dataSetHelper = DataSetHelper.GetInstance();

            DataRow dataRow = dataSetHelper.TableCategories.NewRow();
            dataRow[DataSetHelper.COLUMN_CATEGORIES_NAME] = category.Name;
            dataRow[DataSetHelper.COLUMN_CATEGORIES_AGE] = category.Age;
            dataRow[DataSetHelper.COLUMN_CATEGORIES_ID] = category.Id;

            dataSetHelper.TableCategories.Rows.Add(dataRow);
            dataSetHelper.save();
        }

        public static void remove(int index)
        {
            DataSetHelper dataSetHelper = DataSetHelper.GetInstance();
            dataSetHelper.TableCategories.Rows.RemoveAt(index);
            dataSetHelper.save();
        }

        public static void update(int index, string name, AgeRange age) {
            DataSetHelper dataSetHelper = DataSetHelper.GetInstance();
            dataSetHelper.TableCategories.Rows[index][0] = name;
            dataSetHelper.TableCategories.Rows[index][1] = age;
            dataSetHelper.save();
        }

        public static void update(int index, Category category)
        {
            DataSetHelper dataSetHelper = DataSetHelper.GetInstance();
            dataSetHelper.TableCategories.Rows[index][0] = category.Name;
            dataSetHelper.TableCategories.Rows[index][1] = category.Age;
            dataSetHelper.save();
        }
    }
}
