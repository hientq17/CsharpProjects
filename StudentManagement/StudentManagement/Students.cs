using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement {

    class Students {
        private string stdId;
        private string stdName;
        private string classId;

        public Students(string stdId, string stdName, string classId) {
            this.StdId = stdId;
            this.StdName = stdName;
            this.ClassId = classId;
        }

        public string StdId { get => stdId; set => stdId = value; }
        public string StdName { get => stdName; set => stdName = value; }
        public string ClassId { get => classId; set => classId = value; }
    }
}
