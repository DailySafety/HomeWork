//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeWork.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.Classes = new HashSet<Class>();
        }
    
        public int TeacherId { get; set; }
        public string TeacherNo { get; set; }
        public string TeacherName { get; set; }
        public string PassWord { get; set; }
        public bool Stauts { get; set; }
    
        public virtual ICollection<Class> Classes { get; set; }
    }
}
