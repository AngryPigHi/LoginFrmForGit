using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginFrm
{
    class School
    {

        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 学校地址
        /// </summary>
        public string Address { get; set; }

        public string TeacherName { get; set; }


        public Uri SchoolUrl { get; set; }
    }
}
