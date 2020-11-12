using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement {
    class Classes {
        private string classId;
        private string className;
        private int classYear;

        public Classes(string classId, string className, int classYear) {
            this.classId = classId;
            this.className = className;
            this.classYear = classYear;
        }

        public override string ToString() {
            return "- "+className;
        }

        public string ClassId { get => classId; set => classId = value; }
        public string ClassName { get => className; set => className = value; }
        public int ClassYear { get => classYear; set => classYear = value; }


    }
}
