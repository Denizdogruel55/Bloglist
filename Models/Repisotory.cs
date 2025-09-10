using Microsoft.VisualBasic;

namespace Bloglist.Models;

public class Repisotory()
{
    public static List<Blog> _blog;
    static Repisotory()
    {
        _blog = new List<Blog>()
        {
                new Blog(){Id=1,Title="Html",Content="Html nin Açılımı Hyper text markup Languagetir",Images="1.jpg"},
                new Blog(){Id=2,Title="Css",Content="cssin Açılımı Cascading stylesheets",Images="2.jpg"},
                 new Blog(){Id=3,Title="Js",Content="javascript websiteleri etkileşimli hale getiren bir dildir",Images="4.jpeg"}
        };
    }
    public static List<Blog> Blog
    {
        get
        {
            return _blog;
        }
    }
        public static Blog? GetById(int id) {
        return _blog.FirstOrDefault(x => x.Id == id);
        }
        
    }
