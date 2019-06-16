using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 指向同一个对象的多个数组元素例
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact[] ca = new Contact[3];
            ca[0] = new Contact();
            ca[1] = new Contact();
            ca[2] = new Contact();
            ca[0].m_name = "李明";
            ca[0].m_telephone = "010 - 60010800";
            ca[1].m_name = "张鹏";
            ca[1].m_telephone = "010 - 60020300";
            
            //两个数组元素指向同一个对象。因为数组中存放的只是各个引用对象的地址，所以，当ca[2] = ca[0]时，等于说ca[2]与ca[0]的地址重叠，所指代的内容是一样的，当ca[2]的值被改变，ca[0]也随之改变。
            ca[2] = ca[0];
            ca[2].m_telephone = "010 - 50050500";

            //遍访数组ca中的每个成员
            foreach (Contact c in ca)
                Console.WriteLine(c.m_name + "：" + c.m_telephone);

            Console.ReadKey();
        }
    }

    class Contact
    {
        public string m_name;
        public string m_telephone;
    }
}
